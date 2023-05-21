/*--------------------------------------------------------------*/
/*Buscar que palabras empiezan con un letra en un ABB de palabras
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <malloc.h> 
/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define DIM 11

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
//DEFINO EL TIPO CADENA
typedef char cadena[DIM];

//DEFINO EL TIPO ABB
typedef struct TNodoArbolBinario * TapNodoArbolBinario;

typedef struct TNodoArbolBinario{
         int contador;
         cadena palabra;
         TapNodoArbolBinario izq;
         TapNodoArbolBinario der;
         }TNodoArbolBinario;
         
/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerCadena(cadena);
void AgregarEnABB(TapNodoArbolBinario*,cadena);
void MostrarABBPreOrder(TapNodoArbolBinario);
int RecorrerABB (TapNodoArbolBinario, char, int *);

/*Invocaciones no realizadas en el principal*/
void GrabarPalabra(cadena,cadena);
int CompararCadenas(cadena,cadena);
void MostrarPalabra(cadena);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
    //VARIABLES
    cadena miPalabra;
    TapNodoArbolBinario miABB;
    char corte;
    char carac;
    int resu;
    int con =0;
    
    //INICIALIZACION DE VARIABLES
    miABB=NULL;
    
    //COMIENZO
    printf ("\nEjercicio 16 - TP3\n\n");
    
    LeerCadena(miPalabra);
    while (miPalabra[0]!='\0')
    {
          fflush(stdin);
          AgregarEnABB(&miABB, miPalabra);
          LeerCadena(miPalabra);
    }
    
    if (miABB==NULL)
    {
          printf ("\nArbol vacio.");
          printf("\n\nPresione cualquier tecla para continuar...");
    }
    else
    {
        printf("\nIngrese una letra: ");
        carac = getchar();
        resu = RecorrerABB(miABB, carac, &con);
        printf ("\n%i son las cadenas que empiezan con %c.\n", resu, carac);
        printf ("\nRecorrido PreOrden: ");
        MostrarABBPreOrder(miABB);
        
        printf("\n\nPresione cualquier tecla para continuar...");
    }
    getch();
    return 0;
}

/*--------------------------------------------------------------*/
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Función  : LeerCadena
/*Propósito: Lee una cadena por teclado
/*Entrada  : miCadena
/*Salida   : miCadena
/*Pre      : Debe tener como maximo 10 letras
/*Pos      : Cadena actualizada con valor ingresado
/*--------------------------------------------------------------*/
void LeerCadena(cadena miCadena)
{
     //VARIABLES
     int i;
     char car;
     
     //INICIALIZACION DE VARIABLES
     i = 0;
     
     //COMIENZO
     printf("Ingrese una cadena de hasta %d caracteres: ", DIM-1);     
     car = getchar();     
     while ((i < (DIM - 1)) && (car != '\n'))
     {
           miCadena[i] = car;
           car = getchar();
           i++;
     }     
     miCadena[i] = '\0';
}

/*--------------------------------------------------------------*/
/*Función  : AgregarEnABB
/*Propósito: Agregar palabras en un arbol binario de busqueda
/*Entrada  : arbolBinBusc, palabra
/*Salida   : arbolBinBusc
/*Pre      : El arbol debe estar inicializado en null
/*Pos      : Arbol binario de busqueda con valores ingresados
/*--------------------------------------------------------------*/
void AgregarEnABB(TapNodoArbolBinario *arbolBinBusc, cadena palabra)
{
     //VARIABLES
     TapNodoArbolBinario arbAux;
     int compCad;
     
     //COMIENZO
     fflush (stdin);
     arbAux = *arbolBinBusc;     
     
     if (arbAux==NULL)
     {
         arbAux = (TapNodoArbolBinario) malloc (sizeof (struct TNodoArbolBinario));
         GrabarPalabra(arbAux->palabra, palabra);
         arbAux->izq=NULL;
         arbAux->der=NULL;
         arbAux->contador = 1;
         *arbolBinBusc = arbAux;
     }
     else
     {
         compCad = CompararCadenas(palabra, arbAux->palabra);
         if (compCad<0)
         {
              AgregarEnABB(&arbAux->izq, palabra);
         }
         else
         {
             if(compCad > 0)
             {
                 AgregarEnABB(&arbAux->der, palabra);
             }
             else
             {
                 arbAux->contador++;
             }
         }
     }
}
  

/*--------------------------------------------------------------*/
/*Función  : MostrarABBEnPreOrden
/*Propósito: Mostrar arbol binario de busqueda en preorden
/*Entrada  : arbolBinBusc
/*Salida   : -
/*Pre      : Para ser mostrado el arbol debe tener algun elemento
/*Pos      : Arbol mostrado por pantalla
/*--------------------------------------------------------------*/     
void MostrarABBPreOrder (TapNodoArbolBinario arbolBinBusc)
{
     //VARIABLES
     TapNodoArbolBinario arbAux;
     
     //Asignacion de variables
     arbAux=arbolBinBusc;
     
     //COMIENZO
     if (arbAux!= NULL)
     {
         MostrarPalabra(arbAux->palabra);
         MostrarABBPreOrder(arbAux->izq);
         MostrarABBPreOrder(arbAux->der);
     }
}

/*--------------------------------------------------------------*/
/*Función  : GrabarPalabra
/*Propósito: Asigna una cadena a otra cadena
/*Entrada  : palabra
/*Salida   : palabraArbol
/*Pre      : -
/*Pos      : Valor actualizado de palabraArbol
/*--------------------------------------------------------------*/
void GrabarPalabra(cadena palabraArbol,cadena palabra)
{
     //VARIABLES
     int i;
     
     //Inicializacion de variables
     i=0;
     
     while (palabra[i]!= '\0')
     {
         palabraArbol[i]=palabra[i];
         i++;
     }
     palabraArbol[i]= '\0';
}          
         
/*--------------------------------------------------------------*/
/*Función  : CompararCadenas
/*Propósito: Verifica que cadena esta antes que otra, en ordena 
             alfabetico
/*Entrada  : palabra,palabraArbol
/*Salida   : miRes
/*Pre      : -
/*Pos      : miRes sera igual a 0 si las cadenas son iguales,
             igual a 1 si palabra va despues que palabraArbol
             y -1 si palabra va antes que palabraArbol
/*--------------------------------------------------------------*/         
int CompararCadenas (cadena palabra,cadena palabraArbol)
{
    //VARIABLES
    int miRes;
    int i;
    int coincidencias;
    int difEncontrada;
    
    //Inicializacion de variables
    miRes=0;
    coincidencias=0;
    i=0;
    cadena aux;
    
    while (palabra[i]!='\0' &&  palabraArbol[i]!='\0' && coincidencias==i)
    {
          if (palabra[i]==palabraArbol[i])
          {
              coincidencias=coincidencias+1;
              i=i+1;
          }
          else
          {
              i++;
          }
    }
    
    if( palabra[coincidencias] > palabraArbol[coincidencias] )
    {
          miRes=1;
    }
    else
    {
        miRes=-1;
    }
    
    return miRes;
}

/*--------------------------------------------------------------*/
/*Función  : RecorrerABB
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int RecorrerABB (TapNodoArbolBinario A, char c, int *cont)
{    
     TapNodoArbolBinario aux;
     
     aux = A;
     if (aux != NULL)
     {
           if( (aux->palabra[0]) == c)
           {
               *cont = *cont + 1;
           }
           /*
           Avanzamos los punteros de los "hijos"
           */
           RecorrerABB (aux->izq, c, cont);
           RecorrerABB (aux->der, c, cont);
     }
     return (*cont);
}

/*--------------------------------------------------------------*/
/*Función  : MostrarPalabra.
/*Propósito: Muestra palabra
/*Entrada  : miPalabra
/*Salida   : -
/*Pre      : -
/*Pos      : Muestra palabra que se encuentra en un nodo
/*--------------------------------------------------------------*/
void MostrarPalabra(cadena miPalabra)
{
     int i;
     i=0;
     printf ("\n");
     
     while (miPalabra[i] != '\0')
     {
           putchar(miPalabra[i]);
           i=i+1;
     }
}
