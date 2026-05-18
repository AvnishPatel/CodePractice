#include<stdio.h>
#include<string.h>
#include<stdlib.h>
int max(int num1, int num2) 
{
   int result;
 
   if (num1 > num2)
      result = num1;
   else
      result = num2;
 
   return result; 
}
void lcs( char *X, char *Y, int m, int n )
{
   int L[m+1][n+1],i,j;
 
   for (i=0; i<=m; i++)
   {
     for (j=0; j<=n; j++)
     {
       if (i == 0 || j == 0)
       {
         L[i][j] = 0;
       }
       else if (X[i-1] == Y[j-1])
       {
         L[i][j] = L[i-1][j-1] + 1;
       }  
       else
       {
         L[i][j] = max(L[i-1][j], L[i][j-1]);
       }  
     }
   }
 
   int index = L[m][n];
 
   char lcs[index+1];
   lcs[index] = '\0'; 
 

   i = m; 
   j = n;
   while (i > 0 && j > 0)
   {
      if (X[i-1] == Y[j-1])
      {
          lcs[index-1] = X[i-1]; 
          i--; 
          j--; 
          index--;     
      }      
      else if (L[i-1][j] > L[i][j-1])
      {
         i--;
      }   
      else
      {
         j--;
      }   
   }
 
  
   printf("LCS of %s and %s is %s",X,Y,lcs) ;
   printf("\nLength of the subsequence will is:-%d\n",strlen(lcs));
   printf("\nMatrix:-\n");
   printf("\t");
   for (j=0; j<=n; j++)
   {
   	if(j>0)
   	{
   	printf("\t%c",Y[j-1]);
   	}
   }
   printf("\n");
   for (i=0; i<=m; i++)
   {
     if(i>0)
     {
     printf("%c",X[i-1]);
     }
     for (j=0; j<=n; j++)
     {
     	printf("\t%d",L[i][j]);
     }
     printf("\n");
   }
   
}
 
main()
{
  char X[100],Y[100];
  printf("\nEnter the first string:-");
  gets(X);
  printf("\nEnter the second string:-");
  gets(Y);
  int m = strlen(X);
  int n = strlen(Y);
  lcs(X, Y, m, n);
}
