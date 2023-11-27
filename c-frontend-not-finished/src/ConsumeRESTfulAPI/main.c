#include "application.h"

int main(int argc, char *argv[])
{
    app_setup_storage();
    app_http_request();
    return 0;
}
