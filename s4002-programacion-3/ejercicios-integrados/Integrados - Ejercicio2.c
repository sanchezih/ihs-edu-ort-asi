/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <malloc.h>
#include <stdlib.h>

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

typedef struct TNodoArbolBinario * TApNodoArbolBinario;

typedef struct TNodoArbolBinario
{
        int cont;
        int dato;
        TApNodoArbolBinario izq;
        TApNodoArbolBinario der;
}TNodoArbolBinario;

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerLinea(TArchivo, TLinea, char);
void ObtenerPalabra(TLinea, TCadena , TCadena);
void IniciarCadena(TCadena);
void MostrarLinea(TLinea);
void AgregarEnABB(TApNodoArbolBinario*, int);
void MostrarABB (TApNodoArbolBinario);
void CrearLinea(TLinea, TCadena);
void EscribirLinea(TArchivo, TLinea);

/*--------------------------------------------------------------*/
/*Declaraci�n de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
    //VARIABLES
    TCadena miNombreT1; // Puntero a la primer linea del archivo origen
    TCadena cadNum;     // En el guardo los n�meros que levanto de las lineas
    TCadena cadNomb;    // En �l guardo los nombres que levanto de las lineas 
    TArchivo miT1;      // Archivo origen
    TArchivo miT2;      // Archivo destino, en el que guardamos los nombres
    TCadena miNombreT2; // Puntero a la primer linea del archivo destino
    TApNodoArbolBinario miABB;
    TLinea l;
    char c;
    int num;
    
    //INICIALIZACIONES  
    miABB=NULL;
    
    //COMIENZO
    printf("Ejercicio Integrador 2\n\n");
    
    printf("Ingrese ruta del archivo origen: ");
    fflush(stdin);
    scanf("%s", miNombreT1);
   
    printf("Ingrese ruta del archivo destino: ");
    fflush(stdin);
    scanf("%s", miNombreT2);
    
    miT1 = fopen(miNombreT1, "rt");   
    if (miT1 == NULL)
    {
        printf("\nNo se puede abrir el archivo.");
        printf("\n\nPresione cualquier tecla para continuar...");
        getch();
        return(1);
    }
    else
    {
        miT2 = fopen(miNombreT2, "wt");
        IniciarCadena(cadNum);
        IniciarCadena(cadNomb);
        c = fgetc(miT1);
        
        while (!feof(miT1))
        {
              IniciarCadena(l);
              LeerLinea(miT1, l, c);
              ObtenerPalabra(l, cadNum, cadNomb);
              num = CadANum(cadNum);
              AgregarEnABB(&miABB, num);
              IniciarCadena(l);
              CrearLinea(l, cadNomb);
              EscribirLinea(miT2, l);
              c = fgetc(miT1);
        }
        
        printf("\nEl Arbol contiene los numeros:\n");
        MostrarABB (miABB);
        
        printf("\nFin de proceso!");
        fclose(miT1);
        fclose(miT2);
        
        printf("\n\nPresione cualquier tecla para continuar...");
        getch();
        return(0);
    }
}

/*--------------------------------------------------------------*/
/*Funci�n  : LeerLinea
/*Prop�sito: permite asignar a un vector los caracteres de una 
             l�nea de un archivo de texto
/*Entrada  : archivo de texto origen, l�nea para almacenar los
             caracteres, caracter
/*Salida   : l�nea del archivo de texto
/*Pre      : l�nea iniciada, primer car�cter de la l�nea le�da
/*Pos      : l�nea actualizada con car�cter \n (EOL)   
/*--------------------------------------------------------------*/
void LeerLinea(TArchivo arch, TLinea lin, char car)
{
     //VARIABLES
     int i;
     
     //INICIALIZACIONES
     i=0;
     
     //COMIENZO
     while (car != '\n')
     {
           lin[i] = car;
           car = fgetc(arch);
           i++;
     }
     lin[i] = car;
}

/*--------------------------------------------------------------*/
/*Funci�n  : 
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : - 
/*Pos      :  
/*--------------------------------------------------------------*/
void ObtenerPalabra(TLinea lin, TCadena cadNum, TCadena cadNomb)
{
     //VARIABLES
     int i;
     int j;
     int ind;
     int final;
     
     //INICIALIZACIONES
     i=0;
     j=0;
     ind=0;
     final=1;
     
     //COMIENZO
     while(  lin[ind] !='\n' )
     {
             while ((lin[ind] != ' ') && (final==1) )
             {
                   cadNum[i] = lin[ind];
                   i = i+1;
                   ind=ind+1;
             }
             final = 0;
             ind++;
             
             if(lin[ind] !='\n')
             {
                   cadNomb[j] = lin[ind];
                   j = j+1;
             }
     }
     cadNum[i] = '\0';
     cadNomb[j] = '\0';
}

/*--------------------------------------------------------------*/
/*Funci�n  : IniciarCadena
/*Prop�sito: permite iniciar una cadena con el car�cter blanco
/*Entrada  : vector de caracteres que representa la l�nea
/*Salida   : vector de caracteres que representa la l�nea
/*Pre      : -
/*Pos      : vector con blancos asignados en sus posiciones
/*--------------------------------------------------------------*/
void IniciarCadena(TCadena cadena)
{
     //VARIABLES
     int i;
     
     //COMIENZO
     for (i=0; i < dimCad; i++)
     {
         cadena[i] = ' ';
     }
}

/*--------------------------------------------------------------*/
/*Funci�n  : AgregarEnABB
/*Prop�sito: Agregar palabras en un arbol binario de busqueda
/*Entrada  : arbolBinBusc, palabra
/*Salida   : arbolBinBusc
/*Pre      : El arbol debe estar inicializado en null
/*Pos      : Arbol binario de busqueda con valores ingresados
/*--------------------------------------------------------------*/
void AgregarEnABB(TApNodoArbolBinario *abb, int num)
{
     //VARIABLES
     TApNodoArbolBinario abbAux;
     abbAux = *abb;

     if ((*abb) == NULL)
     {
         abbAux=(TApNodoArbolBinario) malloc(sizeof(struct TNodoArbolBinario));

     	 abbAux->dato = num;
	     abbAux->izq = NULL;
    	 abbAux->der = NULL;
	     (*abb) = abbAux;

	 }
     else
     {
         if (num < abbAux->dato)
         {
                 AgregarEnABB(&abbAux->izq, num);
         }
         else
         {
             if (num > (*abb)->dato)
             {
                     AgregarEnABB(&abbAux->der, num);
             }
             else
             {
                 (*abb)->cont = (*abb)->cont + 1;
             }
         }
     }
     *abb = abbAux;
}
     
 /*--------------------------------------------------------------*/
/*Funci�n  : MostrarABB
/*Prop�sito: Mostrar arbol binario de busqueda
/*Entrada  : arbolBinBusc
/*Salida   : -
/*Pre      : Para ser mostrado el arbol debe tener algun elemento
/*Pos      : Arbol mostrado por pantalla
/*--------------------------------------------------------------*/     
void MostrarABB (TApNodoArbolBinario abb)
{
     //VARIABLES
     TApNodoArbolBinario abbAux;
     
     //INICIALIZACIONES
     abbAux= abb;
     
     //COMIENZO
     if (abbAux!= NULL)
     {
         printf("%d\n", abbAux->dato);
         MostrarABB(abbAux->izq);
         MostrarABB(abbAux->der);
     }
}

/*--------------------------------------------------------------*/
/*Funci�n  : EscribirLinea
/*Prop�sito: permite escribir una l�nea en un archivo de texto
/*Entrada  : archivo de texto destino, linea que contiene los
             caracteres a escribir
/*Salida   : archivo de texto
/*Pre      : - 
/*Pos      : archivo de texto actualizado con la l�nea 
/*--------------------------------------------------------------*/
void EscribirLinea(TArchivo T2, TLinea lin)
{
     //VARIABLES
     int i;
     
     //INICIALIZACIONES
     i=0;
     
     //COMIENZO
     while (lin[i] != '\n')
     {
           fputc(lin[i], T2);
           i++;
     }
     fputc(lin[i], T2);
}

/*--------------------------------------------------------------*/
/*Funci�n  : CrearLinea
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : - 
/*Pos      :  
/*--------------------------------------------------------------*/
void CrearLinea(TLinea lin, TCadena cadena)
{
     int i;
     int ind;
     
     i=0;
     ind=0;
     
     while (cadena[i] != '\0')
     {
           lin[ind] = cadena[i];
           i++;
           ind++;
     }
     lin[ind] = '\n';
}

/*--------------------------------------------------------------*/
/*Funci�n  : CadANum
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      :  
/*--------------------------------------------------------------*/
int CadANum(TCadena cad)
{
    int unNum;
    
    unNum = atoi(cad);
    
    return (unNum);
}
