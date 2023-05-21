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
typedef char TVecNum[N];

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerBinario(TVecNum);
int VerificarBinario(TVecNum);
int LongitudDeBinario(TVecNum);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{     
      //VARIABLES
      TVecNum miBin;
      int miRes;
      
      //COMIENZO
      printf("\nTP1-EJ04 - Misma cant. de 0 y 1 en numero binario");
      printf("\n-------------------------------------------------");
      
      LeerBinario(miBin);
      miRes = VerificarBinario(miBin);
      if (miRes == 1)
      {
           printf("\nEl numero ingresado tiene la misma cantidad de ceros y de unos.");
      }else
      {
           printf("\nEl numero ingresado NO tiene la misma cantidad de ceros y de unos.");
      }
      printf("\n\nPresione cualquier tecla para salir...");
      getch();
}

/*--------------------------------------------------------------*/
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Función  : LeerBinario
/*Propósito: Permite la lectura de un vector de ceros y unos
             cuyos elementos son ingresados por la entrada estándar   
/*Entrada  : Vector con elementos ceros y unos.
/*Salida   : Vector con elementos ceros y unos.
/*Pre      : -
/*Pos      : Vector actualizado con los valores ingresados.
/*--------------------------------------------------------------*/
void LeerBinario(TVecNum cad)
{     
     int i;
  
     printf("\n\nIngrese un numero binario de hasta %d caracteres: ", N-1);
     
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
/*Función  : VerificarBinario
/*Propósito: Determinar si un numero binario ingresado como
             parametro, tiene la misma cantidad de ceros y de unos.
/*Entrada  : Cadena de N enteros.
/*Salida   : Entero.
/*Pre      : El vector solo tiene que contener ceros y unos.
/*Pos      : -
/*--------------------------------------------------------------*/
int VerificarBinario(TVecNum miBin)
{     
     int cantCeros;
     int i;
     int res;
     int L;
     
    //COMIENZO
    cantCeros = 0;
    res = 0;
    L = LongitudDeBinario(miBin);
    
    if (L > 1)
    {
          for (i = 0; i < L; i++)
          {
                if( miBin[i] == '0')
                {
                    cantCeros = cantCeros + 1;
                }
          }
          if ((cantCeros == 0) || ((L-cantCeros) == 0))
          {
          }
          else
          {
              if( (L%cantCeros) == 0)
              {
                  res = 1;
              }
          }
	}
	
	return (res);
}

/*--------------------------------------------------------------*/
/*Funcion  : LongitudDeBinario
/*Proposito: Calcular la cantidad de caracteres que posee un
			 vector
/*Entrada  : Cadena de enteros.
/*Salida   : Valor entero indicando la cantidad de caracteres
             que contiene el binario previamente ingresado.
/*Pre      : -
/*Pos      : -
/*--------------------------------------------------------------*/ 
int LongitudDeBinario(TVecNum miBin)
{
  int indi=0;
  while(miBin[indi]!= '\0')
  {
    indi++;
  }
  return indi;
}
