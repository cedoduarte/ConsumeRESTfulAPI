#include "regular_expression.h"

#include <stdio.h>
#include <stdlib.h>
#include <oniguruma.h>

#define EMAIL_REGEX_PATTERN "[a-z0-9._]+@[a-z]+\\.[a-z]{2,3}"

int util_regex_match(char input[], char rx[])
{
    // Define a regular expression pattern
    const UChar *pattern = (const UChar *) rx;

    // Initialize Oniguruma
    OnigEncoding enc = ONIG_ENCODING_UTF8;
    OnigSyntaxType syntax;
    onig_copy_syntax(&syntax, ONIG_SYNTAX_DEFAULT);

    // Compile the regular expression
    regex_t *regex;
    OnigErrorInfo einfo;
    int compile_result = onig_new(&regex, pattern, pattern + onigenc_str_bytelen_null(enc, pattern),
                                    ONIG_OPTION_DEFAULT, enc, &syntax, &einfo);
    if (compile_result != ONIG_NORMAL)
    {
        UChar error_message[ONIG_MAX_ERROR_MESSAGE_LEN];
        onig_error_code_to_str(error_message, compile_result, &einfo);
        fprintf(stderr, "Regex compilation error: %s\n", error_message);
        onig_end();
        return RX_MATCH_ERROR;
    }

    // Try matching test string against the compiled regular expression
    const UChar *testString = (const UChar *) input;
    OnigRegion *region = onig_region_new();
    int match_result = onig_search(regex, testString, testString + onigenc_str_bytelen_null(enc, testString),
                                    testString, testString + onigenc_str_bytelen_null(enc, testString), region,
                                    ONIG_OPTION_NONE);
    if (match_result == ONIG_MISMATCH)
    {
        return RX_MATCH_ERROR;
    }
    onig_region_free(region, 1);

    // Free resources
    onig_free(regex);
    onig_end();
    return RX_MATCH_OK;
}

int is_email(char email[])
{
    return util_regex_match(email, EMAIL_REGEX_PATTERN) == RX_MATCH_OK;
}

