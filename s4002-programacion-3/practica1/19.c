/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define DIM 21

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef char TVecCad[DIM];

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerCadena(TVecCad);
void mostrarCartel(int );
int longitudDeCadena(TVecCad );
int siCad1EsMayorACad2(TVecCad, TVecCad);
void buscarCadena(TVecCad, TVecCad, int );

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
    //VARIABLES
    TVecCad cadena1;
    TVecCad cadena2;
    char dato;
    int esMayor;
    
    //COMIENZO
    printf("\nTP1-EJ19 - Busca indice donde comienza c1 en c2");
    printf("\n-----------------------------------------------\n\n");
      
    LeerCadena(cadena1);  
    LeerCadena(cadena2); 
    esMayor = siCad1EsMayorACad2(cadena1, cadena2);
    buscarCadena(cadena1, cadena2, esMayor);
    printf("\n\nPresione cualquier tecla para continuar...");
    getch();
    return 0;
}

/*--------------------------------------------------------------*/
/*Función  : LeerCadena
/*Propósito: Lee una cadena por teclado
/*Entrada  : cadena
/*Salida   : cadena
/*Pre      : Debe tener como maximo 20 letras
/*Pos      : Cadena actualizada con valor ingresado
/*--------------------------------------------------------------*/
void LeerCadena(TVecCad cadena)
{

   printf("Ingrese una cadena de hasta %d caracteres: \n", DIM-1);
     
     int i = 0;
     char car;
     
     car = getchar();
     
     while ((i < (DIM - 1)) && (car != '\n')){
          cadena[i] = car;
          car = getchar();
          i++;
     }
     cadena[i] = '\0';
}

/*--------------------------------------------------------------*/
/*Función  : chequear si la cadena 2 es menor o igual a cadena 1.
/*Propósito: 
/*Entrada  : cadena 1 y cadena 2
/*Salida   : entero
/*Pre      : -
/*Pos      : -.
/*--------------------------------------------------------------*/
int siCad1EsMayorACad2(TVecCad cadena1, TVecCad cadena2)
{
    int sonIguales=1;
    int longcadena1= longitudDeCadena(cadena1);
    int longcadena2= longitudDeCadena(cadena2);
    if(longcadena2>longcadena1)
    {
      sonIguales=0;
    }
    return sonIguales;
}

/*--------------------------------------------------------------*/
/*Función  : mostrar cartel
/*Propósito: mostrar por pantalla el resultado
/*Entrada  : cadena
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void mostrarCartel(int inicia)
{
     if(inicia!=-1)
     {
        printf("la cadena inicia en %d",inicia+1);
     }
     else
     {
        printf("no existe c1 en c2");
     }
}
  /*--------------------------------------------------------------*/
/*Función  : dar la longitud de la cadena
/*Propósito: 
/*Entrada  : cadena
/*Salida   : entero
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
int longitudDeCadena(TVecCad cadena)
{
  int i=0;
  while(cadena[i]!= '\0')
  {
    i++;
  }
  return i;
}
/*--------------------------------------------------------------*/
/*Función  : buscar un caracter en una cadena
/*Propósito: buscar  un dato char en un vector de caracteres
/*Entrada  : vector de caracteres y dato de tipo caracter
/*Salida   : entero
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
void buscarCadena( TVecCad cadena1, TVecCad cadena2,int esMayor)
{
     int i=0,j=0;
     int inicia=-1;
     int existe=0;
     
     while ((cadena1[i] != '\0')&&(existe==0)&& (esMayor==1))
     {
           if( cadena2[j]==cadena1[i])
           {
               if(inicia==-1)
               {
                  inicia=i;
               }
                 j++;
                 i++;  
               if (cadena2[j] == '\0')
               {
                  existe=1;
               }               
           }
           else if( cadena2[0]==cadena1[i])
           {
                 inicia=i;
                 j=1;
                 i++;   
           }
           else
           {
               inicia=-1;
               j=0;
               i++;
           }
     }
     mostrarCartel(inicia);
}
