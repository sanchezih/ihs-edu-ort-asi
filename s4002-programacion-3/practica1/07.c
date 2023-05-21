/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define N 4

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef char TVecNum[N];

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerVector(TVecNum);
int LongitudDeVector(TVecNum);
int SumaPrecedenctes (TVecNum);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main(){

      TVecNum vecDeNum;
      int miRes;
      
//COMIENZO
      printf("\nTP1-EJ07 - Un elemento es igual a la suma de sus precedenes?");
      printf("\n------------------------------------------------------------");
      printf("\nEl vector tendra %i posiciones.\n", N);
      
      LeerVector(vecDeNum);
      miRes = SumaPrecedenctes(vecDeNum);
      
      if ( miRes == 1)
      {
           printf("\n\nAlguno de los elementos del vector coincide con la suma de los que le preceden.");
      }
      else
      {
          printf("\n\nNingun elemento del vector coincide con la suma de los que le preceden.");
      }

      printf("\n\nPresione cualquier tecla para salir...");
      getch();
}
/*--------------------------------------------------------------*/
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Función  : LeerVector
/*Propósito: permite la lectura de un vector cuyos elementos  
             son ingresados por la entrada estándar   
/*Entrada  : vector con elementos de tipo entero
/*Salida   : vector con elementos de tipo entero
/*Pre      : -
/*Pos      : vector actualizado con los valores ingresados
/*--------------------------------------------------------------*/
void LeerVector(TVecNum vecNum){
     
     int i;
  
     for (i = 0; i < N; i++){
         printf("\nIngrese el elemento para la posicion %d del vector: ", i);
         scanf("%d", &vecNum[i]);
     }
}

/*----------------------------------------------------------*/
/*Función  : SumaPrecedenctes
/*Propósito: Determina si alguno de los elementos
             del vector coincide con la suma de todos los que le preceden.
/*Entrada  : Vector de enteros.
/*Salida   : Entero.
/*Pre      : -
/*Pos      : Retorna 1 si alguno de los elementos del vector
             coincide con la suma de todos los que le preceden
             o 0 en caso contrario.
/*----------------------------------------------------------*/
int SumaPrecedenctes (TVecNum vecDeNum)
{
	int i;
	int sumatoria;
	TVecNum miVect;
	int miRes;

	miRes = 0;
    i=0;
	sumatoria = vecDeNum[0];

        for (i=1; i<=N-1; i++)
    	{
              if (vecDeNum[i]!= sumatoria)
              {
                    sumatoria = sumatoria + vecDeNum[i];
              }
              else
              {
                  miRes = 1;
              }
        }

	return (miRes);
}
