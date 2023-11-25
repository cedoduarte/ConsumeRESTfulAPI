#ifndef LOCAL_STORAGE_H
#define LOCAL_STORAGE_H

#include "utils/sqlite3.h"

#define LOCAL_STORAGE_FILENAME "consumeRESTfulAPI_storage.sqlite"

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

int local_storage_migrate(sqlite3 *db);
int local_storage_seeding_data(sqlite3 *db);

#ifdef __cplusplus
}
#endif

#endif // LOCAL_STORAGE_H
