/*
  Name: Ignacio Sanchez 
  Copyright: 
  Author: 
  Date: 05/11/07 10:39
  Description: Recibe como argumento un archivo de texto y
  devuelve la cantidad de caracteres del mismo (sin EOL y EOF).
*/

/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/
#define dimLin 80
#define dimCad 20

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras
/*--------------------------------------------------------------*/
typedef char TLinea[dimLin];
typedef char TCadena[dimCad];
typedef FILE* TArchivo;

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Declaraci�n de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
    //VARIABLES
    TCadena miNombreOri;
    TArchivo miOri;
    int cantidad = 0;
    
    //COMIENZO
    printf("Ejercicio 1 del TP4\n\n");
    printf("Ingrese ruta del archivo origen: ");
    scanf("%s", miNombreOri);

    miOri = fopen(miNombreOri, "rt");
    if (miOri == NULL)
    {
        printf("\nNo se puede abrir el archivo.");
        printf("\n\nPresione cualquier tecla para continuar...");
        getch();
        return(1);
    }
    else
    {
        cantidad = ContarCaracteres(miOri);
        fclose(miOri);
        printf("\nEl archivo %s tiene %i caracteres (sin contar los espacios).", miNombreOri, cantidad);
        printf("\n\nPresione cualquier tecla para continuar...");
        getch();
        return(0);       
    }
}

/*--------------------------------------------------------------*/
/*Funci�n  : ContarCaracteres
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : -
/*Pos      :  
/*--------------------------------------------------------------*/             
int ContarCaracteres(TArchivo ori)
{
    //VARIABLES
    char c;
    int cant = 0;
    
    //COMIENZO
    
    c = fgetc(ori);
    while(!feof(ori))
    {
        if( (c != ' ') && (c != '\n') )
        {
            cant++;            
        }
        c = fgetc(ori);
    }
    return cant;
}
