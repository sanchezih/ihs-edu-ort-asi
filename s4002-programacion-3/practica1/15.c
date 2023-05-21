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
void invertirCadenas(TVecCad);

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
      printf("\nTP1-EJ15 - Invierte una cadena de catacteres");
      printf("\n-------------------------------------------");
      
      LeerCadena(c);
      printf("\n");
      invertirCadenas(c);
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
  
     printf("\n\nIngrese una cadena de hasta %i caracteres: ", N-1);
     
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
/*Funcion  : invertirCadenas
/*Proposito: Calcular la cantidad de caracteres que posee un
			 vector
/*Entrada  : Cadena de caracteres.
/*Salida   : 
/*Pre      : -
/*Pos      : -
/*--------------------------------------------------------------*/ 
void invertirCadenas(TVecCad cadena1)
{
     TVecCad cadena2;
     int contador=0, medio, longitud;
     int i=0;
     while (cadena1[i] != '\0')
     {
       contador=contador+1;
       i++;
     }
     longitud=contador;
     
     for (i=0;i<longitud;i++)
     {
         contador=contador-1;
         cadena2[contador]=cadena1[i];
     }
     
     cadena2[longitud]='\0';
     printf("Palabra original: %s",cadena1);
     printf("\n");
     printf("Palabra invertida: %s",cadena2);
}
