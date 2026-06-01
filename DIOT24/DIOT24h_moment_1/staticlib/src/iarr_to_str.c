#include <stdio.h>
#include <string.h>
#include <stdbool.h>

#include "iarrop.h"

char *iarr_to_str(char *buf, int *iarr, int ialen) {
    bool first = true;
    char ibuf[16];
    strcpy(buf, "[");
    for(int i = 0; i < ialen; i++) {
        if(first)
            first = false;
        else
            strcat(buf, ", ");
        sprintf(ibuf, "%d", iarr[i]);
        strcat(buf, ibuf);
    }
    strcat(buf, "]");
    return buf;
}
