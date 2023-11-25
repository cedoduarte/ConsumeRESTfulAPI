#include "database.h"

#include <stdio.h>
#include <stdlib.h>

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
            argv[1] ? argv[1] : "NULL",        // Name
            argv[2] ? argv[2] : "NULL",        // Email
            argv[3] ? argv[3] : "NULL",        // Password
            argv[4] ? argv[4] : "NULL",        // Address
            argv[5] ? argv[5] : "NULL",        // Country
            argv[6] ? argv[6] : "NULL",        // City
            argv[7] ? argv[7] : "0.0",         // Salary
            argv[8] ? argv[8] : "0",           // IsDeleted
            argv[9] ? argv[9] : "2023-1-1",    // InsertedDateTime
            argv[10] ? argv[10] : "2023-1-1",  // UpdatedDateTime
            argv[11] ? argv[11] : "2023-1-1",  // DeletedDateTime
            argv[12] ? argv[12] : "1",         // CurrentUserId
            argv[13] ? argv[13] : "2023-1-1"); // Birthdate

    if (mysql_query(mysqlConnection, sql) != 0)
    {
        fprintf(stderr, "mysql_query() failed: %s\n", mysql_error(mysqlConnection));
    }
    else
    {
        printf("User %d inserted successfully\n");
    }
    return 0;
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
{}

int db_insert_products(MYSQL *mysqlConnection, sqlite3 *sqliteConnection)
{}

