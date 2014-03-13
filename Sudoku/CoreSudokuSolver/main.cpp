#include "header.h"
void main()
{
	int **contro;
	int soluongthieu;
	int banco[9][9]={0};
	printf("Solving...");
	mofile(banco);
	timvitrithieu(banco,contro,soluongthieu);
	gia(banco,contro,soluongthieu,0);
	FILE *f;
	f=fopen("output.txt","w+t");
	fprintf(f,"No Solution");
	fclose(f);
}