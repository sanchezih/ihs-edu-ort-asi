/*
  Name: Ignacio Sanchez
  Copyright: 
  Author: 
  Date: 04/11/07 21:15
  Description: 
*/

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

//DECLARACION DEL ARBOL BINARIO DE BUSQUEDA
typedef struct TNodoArbolBinario *TApNodoArbolBinario;

typedef struct TNodoArbolBinario{
        int dato;
        int cont;
        TApNodoArbolBinario izq;
        TApNodoArbolBinario der;
        }TNodoArbolBinario;

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(int*);
void AgregarEnABB (TApNodoArbolBinario *, int);
void MostrarABBPreOrder (TApNodoArbolBinario);
int ContarNodosHoja (TApNodoArbolBinario, int*);
int ContarNodos (TApNodoArbolBinario, int*);

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
      //VARIABLES
      int miDato;
      int res;
      int res2;
      TApNodoArbolBinario miABB;
      int cont=0;
      int contHojas=0;
      
      //ENCABEZADO
      printf("\nTP3 - Ejercicio 15c");
      printf("\nContar nodos con exactamente un hijo");
      printf("\n---------------------------------");
      printf("\n\n");
    
      //COMIENZO
      miABB = NULL;
      LeerDato(&miDato);
      
      while (miDato!=99)
      {
          AgregarEnABB (&miABB, miDato);
          LeerDato(&miDato);
      }
      
      if(miABB != NULL)
      {
          printf("\nLos datos ingresados en PreOrder, con sus respectivas ocurrencias:\n");
          MostrarABBPreOrder (miABB);
          res2 = ContarNodos (miABB, &cont);
          res = ContarNodosHoja (miABB, &contHojas);
          printf("\nEl ABB contiene %i nodo/s, de los cuales %i tiene/n exactamente un hijo.\n", res2, res);
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
     //VARIABLES
     TApNodoArbolBinario P;
     
     //COMIENZO
     if(*ABB == NULL)
     {
         P = (TApNodoArbolBinario) malloc(sizeof(struct TNodoArbolBinario));
         
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

/*--------------------------------------------------------------*/
/*Función  : ContarNodos
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int ContarNodos (TApNodoArbolBinario a, int *cont)
{
    //VARIABLES
    TApNodoArbolBinario aux;
    
    //COMIENZO
    aux = a;
    
    if (aux != NULL)
    {
        *cont = *cont+1;
        ContarNodos(a->izq, cont);
        ContarNodos(a->der, cont);
    }
    return (*cont);
}

/*--------------------------------------------------------------*/
/*Función  : ContarNodosHoja
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int ContarNodosHoja (TApNodoArbolBinario a, int *contHojas)
{
    //VARIABLES
    TApNodoArbolBinario aux;
    int res;
    res = 0;
    
    //COMIENZO
    aux = a;
    
    if (aux != NULL)
    {
        res = verificarUnHijo(a);
        if(res == 1)
        {
            *contHojas = *contHojas+1;
        }
        ContarNodosHoja(a->izq, contHojas);
        ContarNodosHoja(a->der, contHojas);
    }
    return (*contHojas);
}

/*--------------------------------------------------------------*/
/*Función  : verificarUnHijo
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
int verificarUnHijo (TApNodoArbolBinario a)
{
    //VARIABLES
    int res;
    res = 0;
    
    //COMIENZO
    
    if( ((a->izq == NULL) && (a->der != NULL)) || ((a->izq != NULL) && (a->der == NULL)) )
    {
        res = 1;
    }
    return res;
}
