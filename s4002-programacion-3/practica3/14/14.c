/*--------------------------------------------------------------*/
/*Ejercicio 14 - tp3
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Declaración de estructuras 
/*--------------------------------------------------------------*/

//DEFINO EL ARBOL BINARIO DE BUSQUEDA
typedef struct TNodoArbolBinario *TApNodoArbolBinario;

typedef struct TNodoArbolBinario{
        int dato;
        int cont;
        TApNodoArbolBinario izq;
        TApNodoArbolBinario der;
        }TNodoArbolBinario;

//DEFINO LA LISTA SIMPLE
typedef struct TNodoListaSimple *TApNodoListaSimple;
typedef struct TNodoListaSimple {
                                   int dato;
                                   TApNodoListaSimple sig;
                                 }TNodoListaSimple;

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(int*);
void AgregarEnABB (TApNodoArbolBinario *, int);

/*
El puntero al ABB no se pasa por referencia ya que solo se utilizara
para recorrerlo, no para modificarlo
*/
void RecorrerABB (TApNodoArbolBinario, TApNodoListaSimple*);

/*
El prototipo debe tener el mismo orden de los parametros que en los
argumentos
*/
void AgregarAListaSimple (TApNodoListaSimple *, int);

void mostrarListaSimple (TApNodoListaSimple);
void MostrarABBPreOrder (TApNodoArbolBinario);

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{

      int miDato;
      TApNodoArbolBinario miABB;
      TApNodoListaSimple miLista;
      
      printf("\nTP3-EJ14");
      printf("\n\n");
    
      miABB = NULL;
      miLista = NULL;
      LeerDato(&miDato);
      
      while (miDato!=99)
      {
          AgregarEnABB (&miABB, miDato);
          LeerDato(&miDato);
      }
      
      if(miABB != NULL)
      {
          MostrarABBPreOrder (miABB);
          
          /*
          Aqui debes pasar el puntero a la lista para que se
          actualice con el contenido del ABB
          */
          RecorrerABB (miABB, &miLista);
          
          mostrarListaSimple (miLista);
      }
      else
      {
          printf("\nEl ABB no contiene datos.");
      }

      printf("\n\nPresione cualquier tecla para continuar...");
      getch();
      return 0;
}

/*--------------------------------------------------------------*/
/*Función  : LeerDato
/*Propósito: Lee un entero ingresado por la entrada estandar
/*Entrada  : Entero
/*Salida   : Entero
/*Pre      : -
/*Pos      : El numero que fue leido
/*--------------------------------------------------------------*/

void LeerDato(int *miNumero){
       
         printf("Ingrese un entero para ingresar en el ABB (corte = 99): ", miNumero);
         scanf("%i", &(*miNumero));
}

/*--------------------------------------------------------------*/
/*Función  : AgregarEnABB
/*Propósito: Agregar datos a un ABB
/*Entrada  : Entero
/*Salida   : ABB
/*Pre      : -
/*Pos      : El ABB con los datos ingresados previamente
/*--------------------------------------------------------------*/
void AgregarEnABB (TApNodoArbolBinario *ABB, int dato)
{
     TApNodoArbolBinario P;
     
     if(*ABB == NULL)
     {
         P = (TApNodoArbolBinario) malloc(sizeof(struct
 TNodoArbolBinario));
         
         P->dato = dato;
         P->cont = 1;
         P->izq = NULL;
         P->der = NULL;
         *ABB = P;
     }
     else
     {
         if (dato < (*ABB)->dato)
         {
              AgregarEnABB (&(*ABB)->izq, dato);
         }
         else
         {
             if(dato > (*ABB)->dato)
             {
                 AgregarEnABB (&(*ABB)->der, dato);
             }
             else
             {
                 (*ABB)->cont = (*ABB)->cont +1;
             }                 
         }
     }
}

/*--------------------------------------------------------------*/
/*Función  : RecorrerABB
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
void RecorrerABB (TApNodoArbolBinario A, TApNodoListaSimple *L)
{
     int dato;
     
     if (A != NULL)
     {
           AgregarAListaSimple(&(*L), A->dato);
           /*
           Avanzamos los punteros de los "hijos"
           */
           RecorrerABB (A->izq, &(*L));
           RecorrerABB (A->der, &(*L));
     } 
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
void AgregarAListaSimple (TApNodoListaSimple *lista, int dato)
{
     TApNodoListaSimple p, q;
     /* malloc.h = = alloc.h */
     p=(TApNodoListaSimple) malloc(sizeof (struct TNodoListaSimple));
 
     p->dato = dato;
          
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
void mostrarListaSimple (TApNodoListaSimple lista)
{
    if (lista != NULL) {
        mostrarListaSimple ((*lista).sig);
        printf("\nDATO: ");
        printf("%i", (*lista).dato);
    } 
}

/*--------------------------------------------------------------*/
/*Función  : MostrarABBPreOrder
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
void MostrarABBPreOrder (TApNodoArbolBinario a)
{
    if (a != NULL)
    {
        printf("%i - %i\n",(*a).dato, (*a).cont);
        MostrarABBPreOrder((*a).izq);
        MostrarABBPreOrder((*a).der);
    } 
}
