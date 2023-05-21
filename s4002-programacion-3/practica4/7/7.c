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
void IniciarLinea(TLinea);
int ContarCaracteres(TArchivo, char);

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
    char carac;
    
    //COMIENZO
    printf("Ejercicio 7 del TP4\n\n");
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
        fflush(stdin);
        printf("\nIngrese el caracter a buscar: ");
        carac = getchar();
        
        cantidad = ContarCaracteres(miOri, carac);
        fclose(miOri);
        
        printf("\n\nEl caracter %c aparece %i veces en el archivo %s", carac, cantidad, miNombreOri);
        
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
int ContarCaracteres(TArchivo ori, char carac)
{
    //VARIABLES
    char c;
    int canti = 0;
    TLinea l;
    int res;
    
    //COMIENZO
    
    c = fgetc(ori);
    while(!feof(ori))
    {
          if( c == carac )
          {
              canti++;
          }
          c = fgetc(ori);
    }
    return canti;
}
