#include "header.h"
void inrafile(int banco[9][9])
{
	FILE *f;
	f=fopen("output.txt","wt");
	for(int i=0;i<9;i++)
		for(int j=0;j<9;j++)
			fprintf(f,"%d\n",banco[i][j]);
	fclose(f);
}
void gia(int banco[9][9]
					 ,int** &contro
					 ,int soluongthieu
					 ,int a)
{
	if(a==soluongthieu)
	{	
		if(kiemtradatdungcho2(banco))
		{
			inrafile(banco);
			exit(1);
		}
	}
	for(int i=1;i<10;i++)
	{
		*contro[a]=i;
		if(a>0)
		{
			if(kiemtradatdungcho(banco,contro[a]))
			{
				gia(banco,contro,soluongthieu,a+1);
			}
			else
			{
				continue;
			}
		}
		else
		{
			gia(banco,contro,soluongthieu,a+1);;
		}
		
	}
	*contro[a]=0;
}
