/*-----------------------------------------------------------------------*/
//Diseñe e implemente un algoritmo que permita generar una lista con
//enlaces simples compuesta por numeros enteros.
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
                                 }TNodoListaSimple ;


/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaSimple (TAPNodoListaSimple *, int);
void mostrarListaSimple (TAPNodoListaSimple);
void mostrarCartel(string);
void pausa();
/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
      int dato;
      TAPNodoListaSimple lista;
      
      LeerDato("Ingrese el dato: ",&dato);
      lista=NULL;
      
      while (dato!=99)
      {
          AgregarAListaSimple (&lista, dato);
          LeerDato ("Ingrese el dato: ",&dato) ;
      }   

      mostrarListaSimple (lista);

      pausa();
      return 0;
}

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
