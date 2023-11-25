#ifndef DATABASE_H
#define DATABASE_H

#include "utils/sqlite3.h"

#include <mysql/mysql.h>

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

#define DB_OK 0
#define DB_ERROR 1

int db_get_table_total_record_count(MYSQL *conn, char tableName[]);
int db_insert_users(MYSQL *mysqlConnection, sqlite3 *sqliteConnection);
int db_insert_devices(MYSQL *mysqlConnection, sqlite3 *sqliteConnection);
int db_insert_products(MYSQL *mysqlConnection, sqlite3 *sqliteConnection);

#ifdef __cplusplus
}
#endif

#endif // DATABASE_H
