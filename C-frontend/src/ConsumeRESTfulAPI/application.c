#include "application.h"
#include "local_storage.h"
#include "database.h"

#include <stdio.h>
#include <stdlib.h>

int app_setup_local_storage(char filename[])
{
    sqlite3 *conn = NULL;
    // Open database (if it doesn't exist, it will be created)
    const int rc = sqlite3_open(filename, &conn);
    if (rc != SQLITE_OK)
    {
        fprintf(stderr, "Can't open database: %s\n", sqlite3_errmsg(conn));
        return rc;
    }
    else
    {
        fprintf(stdout, "Opened database successfully\n");
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

int app_populate_database(char server[], char user[], char password[], char database[])
{
    MYSQL *mysqlConnection = mysql_init(NULL);
    if (mysqlConnection == NULL)
    {
        fprintf(stderr, "mysql_init() failed\n");
        return APP_ERROR;
    }
    else
    {
        fprintf(stdout, "MySQL initialized!\n");
    }
    if (mysql_real_connect(mysqlConnection, server, user, password, database, 0, NULL, 0) == NULL)
    {
        fprintf(stderr, "mysql_real_connect() failed: %s\n", mysql_error(mysqlConnection));
        mysql_close(mysqlConnection);
        return APP_ERROR;
    }
    else
    {
        fprintf(stdout, "MySQL connection stablished!\n");
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

    // closes SQLite connection
    if (sqliteConnection != NULL)
    {
        sqlite3_close(sqliteConnection);
        sqliteConnection = NULL;
    }

    // closes MySQL connection
    mysql_close(mysqlConnection);

    return APP_OK;
}
