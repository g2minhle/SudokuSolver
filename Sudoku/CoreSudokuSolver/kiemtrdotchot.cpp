#include "header.h"
int dungkhuvuc(int banco[9][9])
{
	int danhdau[9]={0};
	for(int k=0;k<7;k=k+3)
	{
		for(int k1=0;k1<7;k1=k1+3)
		{
			for(int j=0;j<3;j++)
			{
				for(int j2=0;j2<3;j2++)
				{
					danhdau[banco[k+j][k1+j2]-1]++;
				}
			}		
			for(int i=0;i<9;i++)
			{
				if(danhdau[i]!=1)return 0;
				danhdau[i]=0;
			}
		}
	}
	return 1;
}

int dunghang(int banco[9][9])
{
	int danhdau[9]={0};
	for(int i=0;i<9;i++)
	{		
		for(int j=0;j<9;j++)
		{
			danhdau[banco[i][j]-1]++;
		}
		for(int j=0;j<9;j++)
		{
			if(danhdau[j]!=1)return 0;
			danhdau[j]=0;
		}
	}
	return 1;
}

int dungcot(int banco[9][9])
{
	int danhdau[9]={0};
	for(int i=0;i<9;i++)
	{
		for(int j=0;j<9;j++)
		{
			danhdau[banco[j][i]-1]++;
		}
		for(int j=0;j<9;j++)
		{
			if(danhdau[j]!=1)return 0;
			danhdau[j]=0;
		}
	}
	return 1;
}
int kiemtradatdungcho2(int banco[9][9])
{
	if(dunghang(banco))
	{
		if(dungcot(banco))
		{
			if(dungkhuvuc(banco))
			{
				return 1;
			}
		}
	}
	return 0;
}