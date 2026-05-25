#include <stdlib.h>
#include <stdio.h>

int main(int argc, char **argv) {
    char nums[5];
    printf("Ange ett nummer! ");
    fgets(nums, 5, stdin);
    int num = atoi(nums);
    for (int i = 0; i < num; i++) 
        printf("%d  %d\n", i, i*i);
    return 0;
}