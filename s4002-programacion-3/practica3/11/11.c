/*
  Name: 
  Copyright: 
  Author: Ignacio Sanchez
  Date: 01/11/07 14:04
  Description: Ejercicio 11: Generar una lista L con enlaces dobles y elementos de
  tipo entero. Ordenar los elementos.
*/

/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <malloc.h> 
/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define N 10
/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef char string[N];

typedef struct TNodoListaDoble * TapNodoListaDoble;
typedef struct TNodoListaDoble
{
        int dato;
        TapNodoListaDoble ant;
        TapNodoListaDoble sig;
}TNodoListaDoble;



/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(int*);
void AgregarAListaDoble(TapNodoListaDoble *, TapNodoListaDoble *, int);
void OrdenarListaDoble(TapNodoListaDoble*);
void mostrarListaDoble(TapNodoListaDoble);
void mostrarCartel(string);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
    int miDato;
    int res;
    TapNodoListaDoble miPri;
    TapNodoListaDoble miUlt;
    
//COMIENZO

    printf("\n*********************************************************************");
    printf("\nTP3-EJ11 - ORDENAR LOS DATOS INGRESADOS EN UNA LISTA DOBLE DE ENTEROS");
    printf("\n*********************************************************************");
    
    miPri=NULL;
    
    LeerDato(&miDato);
    
    while (miDato!=99)
    {
          AgregarAListaDoble(&miPri, &miUlt, miDato);
          LeerDato(&miDato);
    }
    
    if (miPri==NULL)
    {
                    printf ("La lista está vacía");
    }
   else
   {
        printf ("\nLa Lista en el orden de ingreso es:"); 
        mostrarListaDoble(miPri);
        OrdenarListaDoble((&miPri));
        printf ("\nLa Lista ordenada es:"); 
        mostrarListaDoble(miPri);
   }
   
   printf("\nPresione cualquier tecla para salir...");
   getch();
   return 0;
}

/*--------------------------------------------------------------*/
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Función  : LeerNumero
/*Propósito: Lee un entero ingresado por la entrada estandar
/*Entrada  : un entero
/*Salida   : un entero
/*Pre      : -
/*Pos      : el numero que fue leido
/*--------------------------------------------------------------*/

void LeerDato(int *miNumero){
       
         printf("\nIngrese un numero <99> para terminar: ", miNumero);
         scanf("%i", &(*miNumero));
}


/*--------------------------------------------------------------*/
/*Función  : AgregarAListaSimple
/*Propósito: Agregar un elemento de tipo entero, leido por la entrada
             estandar a una lista simple.
/*Entrada  : un puntero a una lista simple, y un entero
/*Salida   : lista simple 
/*Pre      : La lista debe estar inicializada.
/*Pos      : lista simple con elementos agregados.
/*--------------------------------------------------------------*/
void AgregarAListaDoble(TapNodoListaDoble *pri, TapNodoListaDoble *ult, int miNumero)
{
     TapNodoListaDoble p;
     TapNodoListaDoble primero;
     TapNodoListaDoble ultimo;
     
     p=(TapNodoListaDoble) malloc (sizeof (struct TNodoListaDoble));
     primero=(TapNodoListaDoble) malloc (sizeof (struct TNodoListaDoble));
     ultimo=(TapNodoListaDoble) malloc (sizeof (struct TNodoListaDoble));
     
     primero = *pri;
     ultimo = *ult;
     (*p).dato=miNumero;
     
     if (primero == NULL)
     {
          (*primero).dato = miNumero;
          primero->ant = NULL;
          primero->sig = NULL;
          ultimo = primero;
     }
     else
     {
         ultimo->sig = p;
         p->ant = *ult;
         ultimo = p;
         ultimo->sig = NULL;
     }
}
       


/*--------------------------------------------------------------*/
/*Función  : OrdenarLista
/*Propósito: Ordena los elementos de una lista simple en orden ascendente
/*Entrada  : lista simple
/*Salida   : lista simple 
/*Pre      : La lista debe tener valores para ordenar
/*Pos      : Lista simple ordenada.
/*--------------------------------------------------------------*/

void OrdenarListaDoble(TapNodoListaDoble *l)
{
     TapNodoListaDoble p;
     TapNodoListaDoble q;
     int aux;
     
     p=*l;

     while (p->sig!=NULL){
        q=p->sig;
          while (q!=NULL){
            if (q->dato>p->dato){
            aux=p->dato;
            p->dato=q->dato;
            q->dato=aux;
          }
          q=q->sig;
       }
     p=p->sig;
     }    
}
   
 


/*--------------------------------------------------------------*/
/*Función  : mostrarListaDoble
/*Propósito: Muestra los elementos de la lista
/*Entrada  : miLista
/*Salida   : -
/*Pre      : La lista debe tener elementos para mostrar
/*Pos      : -
/*--------------------------------------------------------------*/
     
void mostrarListaDoble (TapNodoListaDoble lista)
{
    if (lista != NULL) {
        mostrarListaDoble((*lista).sig);
        mostrarCartel("\nDATO: ");
        printf("%i",(*lista).dato);
    } 
}

/*--------------------------------------------------------------*/
/*Función  : mostrar cartel
/*Propósito: mostrar por pantalla el resultado
/*Entrada  : cadena
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void mostrarCartel(string cartel)
{
    printf(cartel);
}
