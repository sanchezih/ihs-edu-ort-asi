/*-----------------------------------------------------------------------*/
//Ejercicio 6: Dada una lista L con enlaces simples compuesta por numeros enteros.
//(a) Sumar en forma iterativa los elementos de L.
/*-----------------------------------------------------------------------*/

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
typedef struct TNodoListaSimple *TAPNodoListaSimple;
typedef struct TNodoListaSimple {
                                   int dato;
                                   TAPNodoListaSimple sig;
                                 }TNodoListaSimple;

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaSimple (TAPNodoListaSimple *, int);
void mostrarCartel(string);
int sumarDatos(TAPNodoListaSimple);
/*--------------------------------------------------------------*/
/*Definición de la función principal
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
/*Función  : LeerDato
/*Propósito: Lee un dato entero por teclado
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
/*Función  : agregar el dato a la lista
/*Propósito: permite agregar un dato numerico a la lista al comienzo
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
/*Función  : muestra la lista
/*Propósito: permite mostrar por pantalla la lista cargada
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
/*Función  : sumarDatos
/*Propósito: 
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
