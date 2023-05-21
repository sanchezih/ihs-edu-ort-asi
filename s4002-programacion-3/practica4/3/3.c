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
int VerificarCoincidencias(TArchivo, TLinea, char);
//void EscribirLinea(TArchivo, TLinea);

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
    printf("Ejercicio 3 del TP4\n\n");
    printf("Muestra la cantidad de lineas con parantesis balanceados y no balanceados.\n\n");
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
        cantidad = ContarLineas(miOri);
        fclose(miOri);
        printf("\n\nLa cantidad de lineas que tienen sus parantesis balanceados es: %i", cantidad);
        printf("\n\nPresione cualquier tecla para continuar...");
        getch();
        return(0);       
    }
}

/*--------------------------------------------------------------*/
/*Funci�n  : ContarLineas
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : -
/*Pos      :  
/*--------------------------------------------------------------*/             
int ContarLineas(TArchivo ori)
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
          res = VerificarCoincidencias(ori, l, c);
          if( res == 0 )
          {
              canti++;
          }
          c = fgetc(ori);
    }
    return canti;
}

/*--------------------------------------------------------------*/
/*Funci�n  : VerificarCoincidencias
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      :  
/*--------------------------------------------------------------*/
int VerificarCoincidencias(TArchivo arch, TLinea lin, char car){

     int cant = 0;
     
     if(car != '\n')
     {
         while (car != '\n')
         {
               if( (car == '(') )
               {
                    cant++;
               }
               if(car == ')')
               {
                    cant--;
               }
               car = fgetc(arch);
         }
     }
     else
     {
         cant = -10;
     }
     return (cant);
}
