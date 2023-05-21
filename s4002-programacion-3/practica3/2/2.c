/*-----------------------------------------------------------------------*/
//Dise�e e implemente un algoritmo que permita generar una lista con
//enlaces dobles compuesta por numeros enteros.
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
typedef struct TNodoListaDoble *TAPNodoListaDoble;
typedef struct TNodoListaDoble {
                                   int dato;
                                   TAPNodoListaDoble ant;
                                   TAPNodoListaDoble sig;
                                 }TNodoListaDoble;


/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaDoble (TAPNodoListaDoble *, int);
void mostrarListaDoble (TAPNodoListaDoble);
void mostrarCartel(string);
void pausa();
/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
      int dato;
      TAPNodoListaDoble lista;
      
      LeerDato("Ingrese el dato: ",&dato);
      lista=NULL;
      
      while (dato!=99)
      {
          AgregarAListaDoble (&lista, dato);
          LeerDato ("Ingrese el dato: ",&dato) ;
      }   

      mostrarListaDoble (lista);

      pausa();
      return 0;
}

/*--------------------------------------------------------------*/
/*Funci�n  : generar pausa
/*Prop�sito: permite que la pantalla se pause para poder ver los
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
/*Funci�n  : AgregarAListaDoble
/*Prop�sito: colocar en una lista doble los datos ingresados por
//           parametro.
/*Entrada  : entero.
/*Salida   : -
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void AgregarAListaDoble (TAPNodoListaDoble *lista, int  dato)
{
     TAPNodoListaDoble p, q;
     /* malloc.h = = alloc.h */
     p=(TAPNodoListaDoble) malloc(sizeof (struct TNodoListaDoble));
 
     p->dato = dato;//(*p).dato = dato;
     
     if (*lista == NULL) {
         p->sig = NULL;
         p->ant = NULL;
     }
     else {
          p->sig = *lista;
          p->ant = NULL;
     }
     *lista = p;
}

/*--------------------------------------------------------------*/
/*Funci�n  : mostrarListaDoble
/*Prop�sito: permite mostrar por pantalla la lista cargada
/*Entrada  : lista doble.
/*Salida   : lista doble.
/*Pre      : la lista debe tener nodos con datos enteros.
/*Pos      : lista doble con los datos de sus nodos.
/*--------------------------------------------------------------*/ 
void mostrarListaDoble (TAPNodoListaDoble lista)
{
    if (lista != NULL) {
        mostrarListaDoble((*lista).sig);
        mostrarCartel("\nDATO: ");
        printf("%i",(*lista).dato);
    } 
}

/*--------------------------------------------------------------*/
/*Funci�n  : mostrarCartel
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
