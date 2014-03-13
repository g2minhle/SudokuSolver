#include "header.h"
int dungkhuvuc(int banco[9][9],int hang,int cot)
{
	int danhdau[9]={0};
	int dongkhuvuc,cotkhuvuc;
	dongkhuvuc=hang/3;
	cotkhuvuc=cot/3;
	int i,j;
	i=dongkhuvuc*3;
	j=cotkhuvuc*3;
	for(int k=0;k<3;k++)
	{
		for(int k1=0;k1<3;k1++)
		{
			if(banco[k+i][k1+j]!=0)
			{danhdau[banco[k+i][k1+j]-1]++;}
		}
	}
	for(int k=0;k<9;k++)
	{
		if(danhdau[k]>1)return 0;
		danhdau[k]=0;
	}
	return 1;
}

int dunghang(int banco[9][9],int hang)
{
	int danhdau[9]={0};
	for(int i=0;i<9;i++)
	{		
		if(banco[hang][i]!=0)
		{danhdau[banco[hang][i]-1]++;}
	}
	for(int i=0;i<9;i++)
	{
		if(danhdau[i]>1)return 0;
		danhdau[i]=0;
	}
	return 1;
}

int dungcot(int banco[9][9],int cot)
{
	int danhdau[9]={0};
	for(int i=0;i<9;i++)
	{
		if(banco[i][cot]!=0)
		{danhdau[banco[i][cot]-1]++;}
	}
	for(int i=0;i<9;i++)
	{
		if(danhdau[i]>1)return 0;
		danhdau[i]=0;
	}
	return 1;
}

void timvitrichocontro(int banco[9][9],int *contro
					  ,int &hang,int &cot)
{
	for(int i=0;i<9;i++)
	{
		for(int j=0;j<9;j++)
		{
			if(&banco[i][j]==contro)
			{
				hang=i;cot=j;
				return;
			}
		}
	}
}
int kiemtradatdungcho(int banco[9][9],int *contro)
{
	int hang,cot;
	timvitrichocontro(banco,contro,hang,cot);
	if(dunghang(banco,hang))
	{
		if(dungcot(banco,cot))
		{
			if(dungkhuvuc(banco,hang,cot))
			{
				return 1;
			}
		}
	}
	return 0;
}