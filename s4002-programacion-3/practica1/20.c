/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define N 8

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef char TCadCar[N];

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
//void LeerCadena(TCadCar);
int VerificarCadena(TCadCar);
int LongitudDeCadena(TCadCar);
void LeerCadena(TCadCar);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main(){

      TCadCar miCadCar;
      int miRes;
      
      printf("\nTP1-EJ20 - Cadena palindroma");
      printf("\n----------------------------");
      
      LeerCadena(miCadCar);
      miRes = VerificarCadena(miCadCar);
      if (miRes == 1 )
      {
           printf("\nLa cadena ingresada es palindroma.");
      }else
      {
           printf("\nLa cadena ingresada NO es palindroma.");
      }
      printf("\n\nPresione cualquier tecla para salir...");
      getch();
}

/*--------------------------------------------------------------*/
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Función  : LeerCadena
/*Propósito: Permite la lectura de un vector cuyos elementos  
             son ingresados por la entrada estandar.
/*Entrada  : Vector con elementos de tipo caracter.
/*Salida   : Vector con elementos de tipo caracter.
/*Pre      : -
/*Pos      : Vector actualizado con los valores ingresados.
/*--------------------------------------------------------------*/
void LeerCadena(TCadCar cad)
{
     //VARIABLES
     int i;
     char car;
     
     //COMIENZO  
     printf("\n\nIngrese una cadena de hasta %d caracteres: ", N-1);
     
     i = 0; 
     car = getchar();
     
     while ((i < (N - 1)) && (car != '\n'))
     {
           cad[i] = car;
           car = getchar();
           i = i+1;
     }
     cad[i] = '\0';
}

/*--------------------------------------------------------------*/
/*Función  : VerificarCadena
/*Propósito: Permite determinar si la cadena de caracteres que
             se le ingresa como parámetro es o no palíndroma.
/*Entrada  : Cadena de N caracteres.
/*Salida   : Lógico.
/*Pre      : -
/*Pos      : Verdadero si la cadena ingresada es palíndroma, falso si no lo es.
/*--------------------------------------------------------------*/
int VerificarCadena(TCadCar miCadCar)
{
     //VARIABLES     
     int p;
     int f;
     int res;
     
    //COMIENZO
    p = 0;
    f = LongitudDeCadena(miCadCar);
    res = 1;
    
    if (f > 0)
    {
          while (p < f)
          {
                if( miCadCar[p] == miCadCar[f-1] )
                {
                    p = p+1;
                    f = f-1;
                }
                else
                {
                    p = p+f;
					res = 0;
				}
          }
	}
	else
    {
		res = 0;
	}
	
	return (res);
}

/*--------------------------------------------------------------*/
/*Funcion  : LongitudDeCadena
/*Proposito: Calcular la cantidad de caracteres que posee un
			 vector.
/*Entrada  : Cadena de catacteres.
/*Salida   : Valor entero indicando la cantidad de caracteres
			 que contiene la cadena previamente ingresada.
/*Pre      : -
/*Pos      : -
/*--------------------------------------------------------------*/ 
int LongitudDeCadena(TCadCar miCadCar)
{
  int indi=0;
  while(miCadCar[indi]!= '\0')
  {
    indi++;
  }
  return indi;
}
