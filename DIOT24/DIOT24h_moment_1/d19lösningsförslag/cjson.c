#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#include <cjson/cJSON.h>

char myJSON[] = 
"{"
"    \"name\": \"Awesome 4K\","
"    \"resolutions\": ["
"        {"
"            \"width\": 1280,"
"            \"height\": 720"
"        },"
"        {"
"            \"width\": 1920,"
"            \"height\": 1080"
"        },"
"        {"
"            \"width\": 3840,"
"            \"height\": 2160"
"        }"
"    ]"
"}";

int main(int argc, char **argv) {
    cJSON *json = cJSON_Parse(myJSON);
    char *string = cJSON_Print(json);
    printf("JSON:\n%s\n", string);
    return 0;
}