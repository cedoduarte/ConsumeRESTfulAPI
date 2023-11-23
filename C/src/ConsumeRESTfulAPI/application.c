#include "application.h"
#include "local_storage.h"

#include <stdio.h>
#include <stdlib.h>

int app_setup_local_storage(void)
{
    sqlite3 *db = NULL;
    // Open database (if it doesn't exist, it will be created)
    const int rc = sqlite3_open("consumeRESTfulAPI_localstorage.sqlite", &db);
    if (rc)
    {
        fprintf(stderr, "Can't open database: %s\n", sqlite3_errmsg(db));
        return rc;
    }
    else
    {
        fprintf(stdout, "Opened database successfully\n");
    }
    if (local_storage_migrate(db) == SQLITE_ERROR)
    {
        return SQLITE_ERROR;
    }
    if (local_storage_seeding_data(db) == SQLITE_ERROR)
    {
        return SQLITE_ERROR;
    }
    // Close the database
    sqlite3_close(db);
    return SQLITE_OK;
}
