#include "restful.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <curl/curl.h>

// Callback function to write received data into a string
static size_t write_callback(void *contents, size_t size, size_t nmemb, char **output)
{
    size_t total_size = size * nmemb;
    *output = realloc(*output, total_size + 1);
    if (*output)
    {
        memcpy(*output, contents, total_size);
        (*output)[total_size] = '\0';
    }
    return total_size;
}

cJSON* restful_get_resource(char url[])
{
    CURL *curl = NULL;
    CURLcode res;
    cJSON *json = NULL;
    // Initialize cURL
    curl_global_init(CURL_GLOBAL_DEFAULT);
    curl = curl_easy_init();
    if (curl)
    {
        // Set the URL for the GET request
        curl_easy_setopt(curl, CURLOPT_URL, url);

        curl_easy_setopt(curl, CURLOPT_SSL_VERIFYPEER, 0L);
        curl_easy_setopt(curl, CURLOPT_SSL_VERIFYHOST, 0L);
        curl_easy_setopt(curl, CURLOPT_CA_CACHE_TIMEOUT, 604800L);

        curl_easy_setopt(curl, CURLOPT_VERBOSE, 1L);


        curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");

        // Set the callback function to handle the response
        char *response = NULL;
        curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, write_callback);
        curl_easy_setopt(curl, CURLOPT_WRITEDATA, &response);
        // Perform the GET request
        res = curl_easy_perform(curl);
        // Check for errors
        if (res != CURLE_OK)
        {
            fprintf(stderr, "curl_easy_perform() failed: %s\n", curl_easy_strerror(res));
        }
        else
        {
            // Parse JSON response
            json = cJSON_Parse(response);
            if (json == NULL)
            {
                fprintf(stderr, "Error parsing JSON\n");
            }
            /*
            else
            {

                // Access and print values from the JSON object
                cJSON *exampleField = cJSON_GetObjectItem(json, "exampleField");
                if (exampleField != NULL) {
                    printf("Example Field: %s\n", exampleField->valuestring);
                }

                // Clean up cJSON
                cJSON_Delete(json);
            }
            */
        }
        // Clean up cURL
        curl_easy_cleanup(curl);
        // Free the response buffer
        free(response);
    }
    // Cleanup cURL global state
    curl_global_cleanup();
    return json;
}
