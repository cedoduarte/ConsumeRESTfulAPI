#include "application.h"
#include "local_storage.h"
#include "database.h"

#include <stdio.h>
#include <stdlib.h>

#define APP_OK 0
#define APP_ERROR 1

static int app_setup_local_storage(char filename[])
{
    sqlite3 *conn = NULL;
    // Open database (if it doesn't exist, it will be created)
    const int rc = sqlite3_open(filename, &conn);
    if (rc != SQLITE_OK)
    {
        printf("Can't open database: %s\n", sqlite3_errmsg(conn));
        return rc;
    }
    else
    {
        printf("Opened database successfully\n");
    }
    if (local_storage_migrate(conn) == SQLITE_ERROR)
    {
        return SQLITE_ERROR;
    }
    if (local_storage_seeding_data(conn) == SQLITE_ERROR)
    {
        return SQLITE_ERROR;
    }
    // Close the database
    sqlite3_close(conn);
    return SQLITE_OK;
}

static int app_populate_database(char server[], char user[], char password[], char database[])
{
    MYSQL *mysqlConnection = mysql_init(NULL);
    if (mysqlConnection == NULL)
    {
        printf("mysql_init() failed\n");
        return APP_ERROR;
    }
    else
    {
        printf("MySQL initialized!\n");
    }
    if (mysql_real_connect(mysqlConnection, server, user, password, database, 0, NULL, 0) == NULL)
    {
        printf("mysql_real_connect() failed: %s\n", mysql_error(mysqlConnection));
        mysql_close(mysqlConnection);
        return APP_ERROR;
    }
    else
    {
        printf("MySQL connection stablished!\n");
    }
    sqlite3 *sqliteConnection = NULL;
    const int userCount = db_get_table_total_record_count(mysqlConnection, "users");
    const int deviceCount = db_get_table_total_record_count(mysqlConnection, "devices");
    const int productCount = db_get_table_total_record_count(mysqlConnection, "products");
    if (userCount == 0 || deviceCount == 0 || productCount == 0)
    {
        sqlite3_open(LOCAL_STORAGE_FILENAME, &sqliteConnection);
    }
    if (sqliteConnection != NULL)
    {
        if (userCount == 0)
        {
            db_insert_users(mysqlConnection, sqliteConnection);
        }
        if (deviceCount == 0)
        {
            db_insert_devices(mysqlConnection, sqliteConnection);
        }
        if (productCount == 0)
        {
            db_insert_products(mysqlConnection, sqliteConnection);
        }
    }
    else
    {
        printf("mysql-storage: table users already has records!\n");
        printf("mysql-storage: table devices already has records!\n");
        printf("mysql-storage: table products already has records!\n");
    }
    // closes SQLite connection
    if (sqliteConnection != NULL)
    {
        sqlite3_close(sqliteConnection);
        sqliteConnection = NULL;
    }
    // closes MySQL connection
    mysql_close(mysqlConnection);
    mysqlConnection = NULL;
    return APP_OK;
}

void app_setup_storage(void)
{
    if (app_setup_local_storage(LOCAL_STORAGE_FILENAME) == APP_OK)
    {
        if (app_populate_database("localhost", "root", "root", "consumerestfulapi") == APP_OK)
        {
            printf("Database populated successfully!\n");
        }
        else
        {
            printf("Database is not populated!\n");
        }
    }
    else
    {
        printf("Error with setup local storage!");
    }
}
