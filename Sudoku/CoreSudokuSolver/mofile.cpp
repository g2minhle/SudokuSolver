#include "header.h"
#include "header.h"
void mofile(int banco[9][9])
{
	FILE *f;
	f=fopen("input.txt","r+t");
	for(int i=0;i<9;i++)
		for(int j=0;j<9;j++)
			fscanf(f,"%d",&banco[i][j]);
	fclose(f);
}
