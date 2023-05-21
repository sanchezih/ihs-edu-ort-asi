/*-----------------------------------------------------------------------*/
//Ejercicio 6: Dada una lista L con enlaces simples compuesta por numeros enteros.
//(a) Sumar en forma iterativa los elementos de L.
/*-----------------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <malloc.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/
#define N 10

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras 
/*--------------------------------------------------------------*/
typedef char string[N];
typedef struct TNodoListaSimple *TAPNodoListaSimple;
typedef struct TNodoListaSimple {
                                   int dato;
                                   TAPNodoListaSimple sig;
                                 }TNodoListaSimple;

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaSimple (TAPNodoListaSimple *, int);
void mostrarCartel(string);
int sumarDatos(TAPNodoListaSimple);
/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
    TAPNodoListaSimple L;
    int listaOK;
    int resu;
    int dato;
    
    //COMIENZO
    
    L=NULL;
    LeerDato("Ingrese un dato (corte=99): ",&dato);
    
    if(dato != 99)
    {
        while (dato!=99)
        {
            AgregarAListaSimple (&L, dato);
            LeerDato ("Ingrese un dato (corte=99): ",&dato);
        }
        resu = sumarDatos(L);
        printf("\nLa suma de los elementos ingresados es %i ",resu);
    }
    else
    {
        printf("\nNo se ingreso ningun numero.");            
    }
    getch();
    return 0;
}

/*--------------------------------------------------------------*/
/*Funci�n  : LeerDato
/*Prop�sito: Lee un dato entero por teclado
/*Entrada  : entero
/*Salida   : entero
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void LeerDato(string mensaje, int *dato)
{
         printf(mensaje);
         scanf("%i", &(*dato));
}

/*--------------------------------------------------------------*/
/*Funci�n  : agregar el dato a la lista
/*Prop�sito: permite agregar un dato numerico a la lista al comienzo
             de la lista
/*Entrada  : un entero y una lista
/*Salida   : no sale nada
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void AgregarAListaSimple (TAPNodoListaSimple *lista,int  dato)
{
     TAPNodoListaSimple p, q;
     /* malloc.h = = alloc.h */
     p=(TAPNodoListaSimple) malloc(sizeof (struct TNodoListaSimple));
 
     p->dato = dato;//(*p).dato = dato;
     
     if (*lista == NULL) {
         p->sig = NULL;
     }
     else {
          p->sig = *lista;
     }
     *lista = p;
}

/*--------------------------------------------------------------*/
/*Funci�n  : muestra la lista
/*Prop�sito: permite mostrar por pantalla la lista cargada
/*Entrada  : una lista
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void mostrarListaSimple (TAPNodoListaSimple lista)
{
    if (lista != NULL) {
        mostrarListaSimple((*lista).sig);
        mostrarCartel("\nDATO: ");
        printf("%i",(*lista).dato);
    } 
}

/*--------------------------------------------------------------*/
/*Funci�n  : sumarDatos
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int sumarDatos(TAPNodoListaSimple L)
{
    int res;
    res =0;
    int acum;
    acum =0;
    
    while(res != 1)
    {
        if(L->sig == NULL)
        {
           res = 1;
           acum = acum+L->dato;
        }
        else
        {
            acum = acum+L->dato;
            L = L->sig;
        }
    }
    return (acum);
}
            
/*--------------------------------------------------------------*/
/*Funci�n  : mostrar cartel
/*Prop�sito: mostrar por pantalla el resultado
/*Entrada  : cadena
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void mostrarCartel(string cartel)
{
    printf(cartel);
}
