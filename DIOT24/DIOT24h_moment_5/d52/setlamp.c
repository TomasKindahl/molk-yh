#include <string.h>
#include <stdio.h>
#include <curl/curl.h>

size_t write_callback(void *ptr, size_t size, size_t nmemb, void *userdata) {
    fwrite(ptr, size, nmemb, stdout); // Write response to stdout
    return size * nmemb;
}

char UNOon[]= "http://192.168.1.50/H";  // Justera adressen!!
char UNOoff[]= "http://192.168.1.50/L"; // Justera adressen!!

int main(int argc, char **argv) {
    CURL *curl;
    CURLcode res;

    if(argc < 2) {
        printf("Usage: setlamp on\n");
        printf("   or: setlamp off\n");
        return -1;
    }

    curl = curl_easy_init();
    if(curl) {
        if(0 == strcmp(argv[1], "on")) {
            curl_easy_setopt(curl, CURLOPT_URL, UNOon);
        }
        else {
            curl_easy_setopt(curl, CURLOPT_URL, UNOoff);
        }
        curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, write_callback);

        // Perform the request
        res = curl_easy_perform(curl);
        if(res != CURLE_OK) {
            fprintf(stderr, "curl_easy_perform() failed: %s\n", curl_easy_strerror(res));
        }

        // Clean up
        curl_easy_cleanup(curl);
    }

    return 0;
}