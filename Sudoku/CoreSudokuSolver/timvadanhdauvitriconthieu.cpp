#include "header.h"
void timvitrithieu(int banco[9][9]
					 ,int** &contro
					 ,int &soluongthieu)
{
	soluongthieu=0;
	contro=(int**)malloc(sizeof(int)*soluongthieu);
	for(int i=0;i<9;i++)
	{
		for(int j=0;j<9;j++)
		{
			if (banco[i][j]==0)
			{
				soluongthieu++;
				contro=(int**)realloc(contro,sizeof(int)*soluongthieu);
				contro[soluongthieu-1]=&banco[i][j];
			}
		}
	}
}
