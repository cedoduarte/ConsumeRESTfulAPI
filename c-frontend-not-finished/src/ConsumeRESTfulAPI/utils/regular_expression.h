#ifndef _UTIL_H
#define _UTIL_H

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

#define RX_MATCH_OK 0
#define RX_MATCH_ERROR 1

int util_regex_match(char input[], char rx[]);

int is_email(char email[]);

#ifdef __cplusplus
}
#endif

#endif // _UTIL_H
