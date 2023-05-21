#include "libreria_tp3.h"

/*--------------------------------------------------------------*/
/*Función  : generar pausa
/*Propósito: permite que la pantalla se pause para poder ver los
             datos
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 

void pausa()
{
     printf("\n\nPresione cualquier tecla para continuar...");
     getch();
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
/*Función  : VerificarLista
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/

int VerificarLista(TAPNodoListaSimple L)
{
    int V;
    V = 1;

//COMIENZO
	if(L == NULL)
	{
         V == 0;
    }
    
    return (V);
}

/*--------------------------------------------------------------*/
/*Proced.  : ContarNodos
/*Proposito: Contar la cantidad de nodos que posee la lista
ingresada como parametro.
/*Entrada  : Lista.
/*Salida   : Entero.
/*Pre      :
/*Pos      : Entero indicando la cantidad de nodos que posee la
lista ingresada como parametro.
/*--------------------------------------------------------------*/

int ContarNodos( TAPNodoListaSimple L)
{
    //VARIABLES
	TAPNodoListaSimple P;
    P=(TAPNodoListaSimple) malloc(sizeof (struct TNodoListaSimple));
	int res;
	res = 0;

//COMIENZO
	P = L;
	while (P != NULL)
	{
		res = res + 1;
		P= P->sig;
     }
	
	return (res);
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
