/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define N 139

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef char TVecCad[N];

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerCadena(TVecCad);
int LongitudDeCadena(TVecCad);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definición de la función principal
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
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Función  : LeerCadena
/*Propósito: Permite la lectura de un vector de caracteres
             cuyos elementos son ingresados por la entrada estándar   
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
