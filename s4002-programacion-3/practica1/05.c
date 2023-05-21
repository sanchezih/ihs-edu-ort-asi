/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/
#define N 2
#define M 2

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras
/*--------------------------------------------------------------*/
typedef int TMatNum[N][M];

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerMatriz(TMatNum);
void mostrarMatriz(TMatNum);
int  RecorrerMatriz(TMatNum);
int CalcularCuadrado(int);

/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
      //VARIABLES
      TMatNum matrizNum;
      int numero;
      
      //COMIENZO
      printf("\nTP1-EJ05 - Suma los cuadrados de los coeficientes de una matriz");
      printf("\n---------------------------------------------------------------");
      printf("\n\n");

      LeerMatriz(matrizNum);
      numero = RecorrerMatriz( matrizNum);
      printf("\nLa suma de los cuadrados de los coeficientes de la matriz es: %i", numero);

      printf("\n\nPresione cualquier tecla para salir...");
      getch();
}

/*--------------------------------------------------------------*/
/*Funci�n  : LeerMatriz
/*Prop�sito: Lee una matriz de enteros por teclado
/*Entrada  : enteros
/*Salida   : matriz de enteros
/*Pre      : 
/*Pos      : matriz de enteros con N x M
/*--------------------------------------------------------------*/
void LeerMatriz(TMatNum matrizNum)
{
     
     int i,j;
  
     for (i = 0; i < N; i++)
     {
         for (j=0;j<M;j++)
         {
             printf("Ingrese el elemento para la posicion %i / %i de la matriz: ", i,j);
             scanf("%d", &matrizNum[i][j]);
         }
     }
}

/*--------------------------------------------------------------*/
/*Funci�n  : Verificacion
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int RecorrerMatriz(TMatNum matriz)
{
     int valor=0;
     int i,j;
     int res=0;
     int suma=0;
     
     for(i=0;i<N;i++)
     {
             for(j=0;j<M;j++)
             {
                  res = CalcularCuadrado(matriz[i][j]);
                  suma = suma + res;
             }
     }
     return suma;
}

/*--------------------------------------------------------------*/
/*Funci�n  : CalcularCuadrado
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int CalcularCuadrado(num)
{
    int cuad;    
    cuad = num*num;
    return cuad;
}
