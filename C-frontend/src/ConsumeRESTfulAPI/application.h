#ifndef APPLICATION_H
#define APPLICATION_H

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

#define APP_OK 0
#define APP_ERROR 1

int app_setup_local_storage(char filename[]);
int app_populate_database(char server[], char user[], char password[], char database[]);

#ifdef __cplusplus
}
#endif

#endif // APPLICATION_H
