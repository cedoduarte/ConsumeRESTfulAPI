#ifndef APPLICATION_H
#define APPLICATION_H

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

void app_setup_storage(void);
void app_http_request(void);

#ifdef __cplusplus
}
#endif

#endif // APPLICATION_H
