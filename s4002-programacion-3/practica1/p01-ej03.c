/*----------------------------------------------------------------------------*/
/* Inclusion de archivos
/*----------------------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*----------------------------------------------------------------------------*/
/* Declaracion de constantes y macros
/*----------------------------------------------------------------------------*/
#define N 6

/*----------------------------------------------------------------------------*/
/* Declaracion de estructuras
/*----------------------------------------------------------------------------*/
typedef char TVecNum[N];

/*----------------------------------------------------------------------------*/
/* Declaracion de prototipos de funciones
/*----------------------------------------------------------------------------*/
void LeerBinario(TVecNum);
int BinarioADecimal(TVecNum);
int LongitudDeBinario(TVecNum);

/*----------------------------------------------------------------------------*/
/* Declaracion de variables globales
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
/* Definicion de la funcion principal
/*----------------------------------------------------------------------------*/
int main()
{     
      //VARIABLES
      int miRes;
      TVecNum miBin;
      
      //COMIENZO
      printf("\nTP1-EJ03 - Transforma un numero binario a decimal");
      printf("\n-------------------------------------------------");
      
      LeerBinario(miBin);
      miRes = BinarioADecimal(miBin);

      printf("\nEl numero ingresado es %i en decimal.", miRes);

      printf("\n\nPresione cualquier tecla para salir...");
      getch();
}

/*----------------------------------------------------------------------------*/
/* Definicion de otras funciones
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
/* Funcion  : LeerBinario
/* Proposito: Permite la lectura de un vector de ceros y unos
              cuyos elementos son ingresados por la entrada estandar   
/* Entrada  : Vector con elementos ceros y unos
/* Salida   : Vector con elementos ceros y unos
/* Pre      : -
/* Pos      : Vector actualizado con los valores ingresados
/*----------------------------------------------------------------------------*/
void LeerBinario(TVecNum bin){
     
     int i;
  
     printf("\n\nIngrese un numero binario de hasta %d caracteres: ", N-1);
     
     i = 0;
     char car;
     
     car = getchar();
     
     while ((i < (N - 1)) && (car != '\n')){
          bin[i] = car;
          car = getchar();
          i=i+1;
     }
     bin[i] = '\0';
}
     
/*----------------------------------------------------------------------------*/
/* Funcion  : BinarioADecimal
/* Proposito: Convierte un numero binario a decimal
/* Entrada  : Numero binario
/* Salida   : Un numero entero base 10 equivalente al binario ingresado
/* Pre      : El vector solo tiene que contener ceros y unos
/* Pos      : Devuelve la representacion decimal del binario ingresado
/*            como parametro
/*----------------------------------------------------------------------------*/
int BinarioADecimal(TVecNum miBin){
     
     int i;
     int potencia;
     int decimalARetornar;
     int cant;
     
//COMIENZO
	decimalARetornar = 0;
	potencia = 1;
	cant = LongitudDeBinario(miBin);
	i = cant;
    
    while (i > 0)
    {
        if (miBin[i-1] == '1')
        {
                       decimalARetornar = decimalARetornar + potencia;
        }
        i = i-1;
        potencia = potencia*2;
    }
	
	return (decimalARetornar);
}


/*----------------------------------------------------------------------------*/
/* Funcion  : LongitudDeBinario
/* Proposito: Calcular la cantidad de caracteres que posee un vector
/* Entrada  : Cadena de catacteres
/* Salida   : Valor entero indicando la cantidad de caracteres que contiene la
/*            cadena previamente ingresada
/* Pre      : 
/* Pos      : 
/*----------------------------------------------------------------------------*/
int LongitudDeBinario(TVecNum miBin)
{
  int indi=0;
  while(miBin[indi]!= '\0')
  {
    indi++;
  }
  return indi;
}
