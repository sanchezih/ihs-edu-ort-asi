/*--------------------------------------------------------------*/
/*Programa : TP 2 - EJERCICIO 04
/*Proposito: Dado un vector de numeros enteros, diseñe e implemente
             un algoritmo recursivo que permita determinar su
             elemento maximo.
/*Fecha    : 23092007
/*Autor    : Ignacio Sanchez.
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define N 5


/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef int TvecNum[N];

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
int numMax(int,int,TvecNum);
void LeerVector(TvecNum);
void mostrarCartel (int);
/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
      TvecNum vector;
      int dato=0;
      
      printf("\n***************************************************************");
      printf("\nTP2-EJ04 - EL MAYOR ELEMENTO DENTRO DEL VECTOR (RECURSIVAMENTE)");
      printf("\n***************************************************************");
     
      LeerVector(vector);
      dato= numMax(N, dato, vector);
      mostrarCartel(dato);
      printf("\n\nPresione cualquier tecla para continuar...");
      getch();
      
      //return 0;
}
/*--------------------------------------------------------------*/
/*Proced.  : numMax
/*Proposito: Determina el elemento maximo dentro de un vector.
/*Entrada  : vector de datos y la dim
/*Salida   : Entero
/*Pre      :
/*Pos      : 
/*--------------------------------------------------------------*/ 
int numMax( int Dim, int dato, TvecNum vector)
{
    int temp;
    if(Dim!=0)
    {  
       temp= numMax( Dim-1, vector[Dim-1],vector);
       if ( dato < temp )
       {
           dato=temp;
       }
    }
    return dato;
}


/*--------------------------------------------------------------*/
/*Función  : LeerVector
/*Propósito: Lee una vector de enterospor teclado
/*Entrada  : enteros
/*Salida   : vector de enteros
/*Pre      : 
/*Pos      : vector de enteros con N de longitud
/*--------------------------------------------------------------*/
void LeerVector(TvecNum vecNum)
{
     
     int i;
  
     for (i = 0; i < N; i++){
         printf("\nIngrese el elemento para la posicion %d del vector: ", i);
         scanf("%d", &vecNum[i]);
     }
}

/*--------------------------------------------------------------*/
/*Función  : mostrarCartel
/*Propósito: mostrar por pantalla si se hallo o no
/*Entrada  : entero
/*Salida   : 
/*Pre      : 
/*Pos      : un valor entero >0
/*--------------------------------------------------------------*/ 
void mostrarCartel(int hallado)
{    
     printf("\n\n%d es el numero mas grande dentro del vector.", hallado);
}
