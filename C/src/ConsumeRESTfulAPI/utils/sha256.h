#ifndef SHA256_H
#define SHA256_H

/*
** Make sure we can call this stuff from C++.
*/
#ifdef __cplusplus
extern "C" {
#endif

// Function to calculate the SHA-256 hash of the input string
char* SHA256(char* data);

#ifdef __cplusplus
}
#endif

#endif // SHA256_H
