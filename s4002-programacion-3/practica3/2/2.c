/*-----------------------------------------------------------------------*/
//Diseñe e implemente un algoritmo que permita generar una lista con
//enlaces dobles compuesta por numeros enteros.
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
typedef struct TNodoListaDoble *TAPNodoListaDoble;
typedef struct TNodoListaDoble {
                                   int dato;
                                   TAPNodoListaDoble ant;
                                   TAPNodoListaDoble sig;
                                 }TNodoListaDoble;


/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaDoble (TAPNodoListaDoble *, int);
void mostrarListaDoble (TAPNodoListaDoble);
void mostrarCartel(string);
void pausa();
/*--------------------------------------------------------------*/
/*Definición de la función principal
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
/*Función  : AgregarAListaDoble
/*Propósito: colocar en una lista doble los datos ingresados por
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
/*Función  : mostrarListaDoble
/*Propósito: permite mostrar por pantalla la lista cargada
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
/*Función  : mostrarCartel
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
