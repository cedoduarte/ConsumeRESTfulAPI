#include "application.h"
#include "local_storage.h"

#include <stdio.h>

int main(int argc, char *argv[])
{
    if (app_setup_local_storage(LOCAL_STORAGE_FILENAME) == APP_OK)
    {
        app_populate_database("localhost", "root", "root", "consumerestfulapi");
    }
    else
    {
        fprintf(stderr, "Error with setup local storage!");
    }
    return 0;
}
