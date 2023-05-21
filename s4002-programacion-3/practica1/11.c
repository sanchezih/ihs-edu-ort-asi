/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/
#define N 139

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras
/*--------------------------------------------------------------*/
typedef char TVecCad[N];

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerCadena(TVecCad);
int LongitudDeCadena(TVecCad);

/*--------------------------------------------------------------*/
/*Declaraci�n de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{     
      //VARIABLES
      TVecCad c;
      int miRes;
      
      //COMIENZO
      printf("\nTP1-EJ11 - Determina la long. de una cadena");
      printf("\n-------------------------------------------");
      
      LeerCadena(c);
      printf("%s", c);
      miRes = LongitudDeCadena(c);
      printf("\nLa longitud es: %i", miRes);
      printf("\n\nPresione cualquier tecla para salir...");
      getch();
}

/*--------------------------------------------------------------*/
/*Definici�n de otras funciones*/
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Funci�n  : LeerCadena
/*Prop�sito: Permite la lectura de un vector de caracteres
             cuyos elementos son ingresados por la entrada est�ndar   
/*Entrada  : Vector con caracteres.
/*Salida   : Vector con caracteres.
/*Pre      : -
/*Pos      : Vector actualizado con los valores ingresados.
/*--------------------------------------------------------------*/
void LeerCadena(TVecCad cad)
{     
     int i;
  
     printf("\n\nIngrese una cadena de hasta %d caracteres: ", N-1);
     
     i = 0;
     char car;
     
     car = getchar();
     
     while ((i < (N - 1)) && (car != '\n')){
          cad[i] = car;
          car = getchar();
          i++;
     }
     cad[i] = '\0';
}
     
/*--------------------------------------------------------------*/
/*Funcion  : LongitudDeCadena
/*Proposito: Calcular la cantidad de caracteres que posee un
			 vector
/*Entrada  : Cadena de caracteres.
/*Salida   : Valor entero indicando la cantidad de caracteres
             que contiene.
/*Pre      : -
/*Pos      : -
/*--------------------------------------------------------------*/ 
int LongitudDeCadena(TVecCad ca)
{
  int indi=0;
  while(ca[indi]!= '\0')
  {
    indi++;
  }
  return indi;
}
