/*-----------------------------------------------------------------------*/
//Dada una lista L1 con enlaces simples y una lista L2 con enlaces dobles,
//ambas compuestas por numeros enteros en cualquier orden. Dise�e e
//implemente algoritmos que permitan:
//(a) Eliminar de L2 los elementos que se encuentran en L1 solo una vez.
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
                                 
typedef struct TNodoListaDoble *TAPNodoListaDoble;
typedef struct TNodoListaDoble {
                                   int dato;
                                   TAPNodoListaDoble sig;
                                   TAPNodoListaDoble ant;
                                 }TNodoListaDoble;

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaSimple (TAPNodoListaSimple *, int);
void mostrarListaSimple (TAPNodoListaSimple);
void mostrarCartel(string);
void pausa();
int VerificarLista (TAPNodoListaSimple);
/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
      int dato;
      TAPNodoListaSimple L1;
      TAPNodoListaDoble L2;
      int res;

//COMIENZO
      L1=NULL;
      L2=NULL;
      
      LeerDato("Ingrese el dato a agregar en L1 (corte = 98): ",&dato);
      while (dato!=98)
      {
          AgregarAListaSimple (&lista, dato);
          LeerDato ("Ingrese el dato a agregar en L1 (corte = 98): ",&dato) ;
      }

      LeerDato("Ingrese el dato a agregar en L2 (corte = 99): ",&dato);
      while (dato!=99)
      {
          AgregarAListaDoble (&lista, dato);
          LeerDato ("Ingrese el dato a agregar en L2 (corte = 99): ",&dato) ;
      }
      
      EliminarCoincidencias (L1, L2);

      MostrarLista(L2)

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
/*Funci�n  : AgregarAListaDoble
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 
void AgregarAListaDoble (TAPNodoListaDoble *L2, int  dato)
{
     TAPNodoListaDoble APAUX;
     /* malloc.h = = alloc.h */
     APAUX=(TAPNodoListaDoble) malloc(sizeof (struct TNodoListaDoble));
 
     L2->dato = dato; //(*p).dato = dato;
     
     if (*L2 == NULL)
     {
         APAUX->ant = NULL;
         APAUX->sig = NULL;
         L2 = APAUX;
     }
     else
     {
         APAUX->sig = L2;
         APAUX->ant = NULL
         L2 = APAUX;
     }
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
/*Funci�n  : VerificarLista
/*Prop�sito: 
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
/*Funci�n  : EliminarCoincidencias
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 

void EliminarCoincidencias (TAPNodoListaSimple L1, TAPNodoListaDoble L2)
{
     //VARIABLES
     int res;
     int dato;
     
     //COMIENZO
     while(corte != NULL)
     {
          res = BuscarEnListaDoble(L2, dato);
          if(res == 1)
          {
                 EliminarDeListaDoble(L2, dato);
          }
          corte = L1->sig;
     }
}

/*--------------------------------------------------------------*/
/*Funci�n  : BuscarEnListaDoble
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 

int BuscarEnListaDoble (TAPNodoListaDoble L2, int dato)
{
     //VARIABLES
     TAPNodoListaDoble P;
     int res;
     
     //COMIENZO
     P = L2;
     res = 0;
     while((P!=NULL) && (res=0))
     {
         if(P->dato == dato)
         {
             res = 1;
         }
         else
         {
             P = P->sig;
         }
     }
     return (res);
}

/*--------------------------------------------------------------*/
/*Funci�n  : EliminarDeListaDoble
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/ 

int EliminarDeListaDoble (TAPNodoListaDoble L2, int dato)
{
     //VARIABLES
     TAPNodoListaDoble P;
     TAPNodoListaDoble Q;
     
     //COMIENZO
     P=L;
     if(P->dato == dato)
     {
         L2=L2->sig
         Disponer(P)
     }
     else
     {
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
