#include "util_string.h"

#include <stdio.h>
#include <string.h>
#include <ctype.h>

void trimmed(char *str)
{
    // Remove leading whitespace
    while (isspace((unsigned char)*str))
    {
        str++;
    }

    // Check if the string is empty after removing leading whitespace
    if (*str == '\0')
    {
        return;  // String is empty
    }

    // Remove trailing whitespace
    char *end = str + strlen(str) - 1;
    while (end > str && isspace((unsigned char)*end))
    {
        end--;
    }

    // Null-terminate the trimmed string
    *(end + 1) = '\0';
}
