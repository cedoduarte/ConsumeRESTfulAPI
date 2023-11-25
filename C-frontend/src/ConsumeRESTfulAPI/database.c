#include "database.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int db_get_table_total_record_count(MYSQL *conn, char tableName[])
{
    // Build the query to get the count of rows in the table
    char query[512];
    snprintf(query, sizeof(query), "SELECT COUNT(*) FROM %s", tableName);
    if (mysql_query(conn, query) == DB_ERROR)
    {
        fprintf(stderr, "mysql_query() failed: %s\n", mysql_error(conn));
        return DB_ERROR;
    }

    MYSQL_RES *result = mysql_store_result(conn);
    if (result == NULL)
    {
        fprintf(stderr, "mysql_store_result() failed: %s\n", mysql_error(conn));
        return DB_ERROR;
    }

    MYSQL_ROW row = mysql_fetch_row(result);
    if (row)
    {
        return atoi(row[0]);
    }
    else
    {
        printf("No rows found.\n");
    }
    mysql_free_result(result);
    return 0;
}

static int db_insert_users_callback(void *data, int argc, char **argv, char **colNames)
{
    MYSQL *mysqlConnection = (MYSQL*)data;
    char sql[512];
    sprintf(sql, "INSERT INTO users(Name,Email,Password,Address,Country,City,Salary,IsDeleted,InsertedDateTime,"
                 "UpdatedDateTime,DeletedDateTime,CurrentUserId,Birthdate) "
                 "VALUES('%s','%s','%s','%s','%s','%s',%s,%s,'%s','%s','%s',%s,'%s');",
            argv[1] ? argv[1] : "none",        // Name
            argv[2] ? argv[2] : "none",        // Email
            argv[3] ? argv[3] : "none",        // Password
            argv[4] ? argv[4] : "none",        // Address
            argv[5] ? argv[5] : "none",        // Country
            argv[6] ? argv[6] : "none",        // City
            argv[7] ? argv[7] : "0.0",         // Salary
            argv[8] ? argv[8] : "0",           // IsDeleted
            argv[9] ? argv[9] : "2023-1-1",    // InsertedDateTime
            argv[10] ? argv[10] : "2023-1-1",  // UpdatedDateTime
            argv[11] ? argv[11] : "2023-1-1",  // DeletedDateTime
            argv[12] ? argv[12] : "1",         // CurrentUserId
            argv[13] ? argv[13] : "2023-1-1"); // Birthdate
    if (mysql_query(mysqlConnection, sql) != DB_OK)
    {
        fprintf(stderr, "mysql_query() failed: %s\n", mysql_error(mysqlConnection));
        return DB_ERROR;
    }
    else
    {
        printf("Users inserted successfully!\n");
    }
    return DB_OK;
}

static int db_insert_devices_callback(void *data, int argc, char **argv, char **colNames)
{
    MYSQL *mysqlConnection = (MYSQL*)data;
    char sql[512];
    sprintf(sql, "INSERT INTO devices(Name,UserId,Price,IsDeleted,InsertedDateTime,UpdatedDateTime,DeletedDateTime,"
                 "CurrentUserId) "
                 "VALUES('%s',%s,%s,%s,'%s','%s','%s',%s);",
            argv[1] ? argv[1] : "none",     // Name
            argv[2] ? argv[2] : "0",        // UserId
            argv[3] ? argv[3] : "0.0",      // Price
            argv[4] ? argv[4] : "0",        // IsDeleted
            argv[5] ? argv[5] : "2023-1-1", // InsertedDateTime
            argv[6] ? argv[6] : "2023-1-1", // UpdatedDateTime
            argv[7] ? argv[7] : "2023-1-1", // DeletedDateTime
            argv[8] ? argv[8] : "1");       // CurrentUserId
    if (mysql_query(mysqlConnection, sql) != DB_OK)
    {
        fprintf(stderr, "mysql_query() failed: %s\n", mysql_error(mysqlConnection));
        return DB_ERROR;
    }
    else
    {
        printf("Devices inserted successfully!\n");
    }
    return DB_OK;
}

static int db_insert_products_callback(void *data, int argc, char **argv, char **colNames)
{
    MYSQL *mysqlConnection = (MYSQL*)data;
    char sql[512];
    sprintf(sql, "INSERT INTO products(Name,Price,QuantityInStock,IsDeleted,InsertedDateTime,UpdatedDateTime,"
                 "DeletedDateTime,CurrentUserId) "
                 "VALUES('%s',%s,%s,%s,'%s','%s','%s',%s);",
            argv[1] ? argv[1] : "none", // Name
            argv[2] ? argv[2] : "0.0", // Price
            argv[3] ? argv[3] : "0", // QuantityInStock
            argv[4] ? argv[4] : "0", // IsDeleted
            argv[5] ? argv[5] : "2023-1-1", // InsertedDateTime
            argv[6] ? argv[6] : "2023-1-1", // UpdatedDateTime
            argv[7] ? argv[7] : "2023-1-1", // DeletedDateTime
            argv[8] ? argv[8] : "1"); // CurrentUserId
    if (mysql_query(mysqlConnection, sql) != DB_OK)
    {
        fprintf(stderr, "mysql_query() failed: %s\n", mysql_error(mysqlConnection));
        return DB_ERROR;
    }
    else
    {
        printf("Products inserted successfully!\n");
    }
    return DB_OK;
}

int db_insert_users(MYSQL *mysqlConnection, sqlite3 *sqliteConnection)
{
    if (sqlite3_exec(sqliteConnection, "SELECT * FROM user;", db_insert_users_callback, mysqlConnection, NULL)
        != SQLITE_OK)
    {
        return DB_ERROR;
    }
    return DB_OK;
}

int db_insert_devices(MYSQL *mysqlConnection, sqlite3 *sqliteConnection)
{
    if (sqlite3_exec(sqliteConnection, "SELECT * FROM device;", db_insert_devices_callback, mysqlConnection, NULL)
        != SQLITE_OK)
    {
        return DB_ERROR;
    }
    return DB_OK;
}

int db_insert_products(MYSQL *mysqlConnection, sqlite3 *sqliteConnection)
{
    if (sqlite3_exec(sqliteConnection, "SELECT * FROM product;", db_insert_products_callback, mysqlConnection, NULL)
        != SQLITE_OK)
    {
        return DB_ERROR;
    }
    return DB_OK;
}
