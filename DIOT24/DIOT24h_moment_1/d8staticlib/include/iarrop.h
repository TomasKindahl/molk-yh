#ifndef _IARROP_H
#define _IARROP_H

/* convert an integer array to a string and put into buffer */
char *iarr_to_str(char *buf, int *iarr, int ialen);

/**** array operations ****/
/* compute and return sum of values in 'iarr' of length 'ialen' */
int isum(int *iarr, int ialen);
/* compute and return alternating difference of values in 'iarr' of length 'ialen' */
int ialtdiff(int *iarr, int ialen);
/* compute and return product of values in 'iarr' of length 'ialen' */
int iprod(int *iarr, int ialen);

/**** accumulated operations ****/
/* compute accumulated sum and put into 'idest' */
int *iaccumsum(int *idest, int *iarr, int ialen);
/* compute accumulated product and put into 'idest' */
int *iaccumprod(int *idest, int *iarr, int ialen);

#endif
