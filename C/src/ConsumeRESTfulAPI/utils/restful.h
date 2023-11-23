/* EXAMPLE

#include <stdio.h>
#include <stdlib.h>

int main()
{
    const char* apiUrl = "http://jsonplaceholder.typicode.com/todos/1";
    char responseBuffer[4096] = {0};  // Adjust the buffer size as needed
    if (getResource(apiUrl, responseBuffer) == 0) {
        printf("Response:\n%s\n", responseBuffer);
    }
    return 0;
}
*/

#ifndef RESTFUL_H
#define RESTFUL_H

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

int getResource(const char* url, char* responseBuffer);
int postResource(const char* url, char* responseBuffer);
int putResource(const char* url, char* responseBuffer);
int deleteResource(const char* url, char* responseBuffer);
int patchResource(const char* url, char* responseBuffer);

#ifdef __cplusplus
}
#endif

#endif // RESTFUL_H
