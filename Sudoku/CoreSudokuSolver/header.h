#ifndef __myheader
#define __myheader
#include <conio.h>
#include <stdio.h>
#include <malloc.h>
#include <stdlib.h>
	void mofile(int banco[9][9]);
	void timvitrithieu(int banco[9][9]
					 ,int** &contro
					 ,int &soluongthieu);
	int kiemtra(int banco[9][9]);
	void gia(int banco[9][9]
					 ,int** &contro
					 ,int soluongthieu
					 ,int a);
	int kiemtradatdungcho(int banco[9][9],int *contro);
	int kiemtradatdungcho2(int banco[9][9]);
#endif