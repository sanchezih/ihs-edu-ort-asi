/*
  Name: 
  Copyright: 
  Author: 
  Date: 07/11/07 00:44
  Description: ABB de numeros
*/
/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras 
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
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(int*);
void AgregarEnABB (TApNodoArbolBinario *, int);
void MostrarABBPreOrder (TApNodoArbolBinario);
void MostrarABBPostOrder (TApNodoArbolBinario);
void MostrarABBInOrder (TApNodoArbolBinario);

/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main()
{
      //VARIABLES
      int miDato;
      TApNodoArbolBinario miABB;
      
      //ENCABEZADO
      printf("\n*******************************************************************");
      printf("\n*************** Generador de ABB de numeros enteros ***************");
      printf("\n*******************************************************************");
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
          
          printf("\n\nLos datos ingresados en InOrder, con sus respectivas ocurrencias:\n");
          MostrarABBInOrder (miABB);
          
          printf("\n\nLos datos ingresados en PostOrder, con sus respectivas ocurrencias:\n");
          MostrarABBPostOrder (miABB);
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
/*Funci�n  : LeerDato
/*Prop�sito: Lee un entero ingresado por la entrada estandar
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
/*Funci�n  : AgregarEnABB
/*Prop�sito: Agregar datos a un ABB
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
/*Funci�n  : MostrarABBPreOrder
/*Prop�sito: 
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
/*Funci�n  : MostrarABBInOrder
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
void MostrarABBInOrder (TApNodoArbolBinario a)
{
    if (a != NULL)
    {
        MostrarABBPreOrder((*a).izq);
        printf("%i - %i\n",(*a).dato, (*a).cont);      
        MostrarABBPreOrder((*a).der);
    } 
}

/*--------------------------------------------------------------*/
/*Funci�n  : MostrarABBPostOrder
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : 
/*Pos      : 
/*--------------------------------------------------------------*/
void MostrarABBPostOrder (TApNodoArbolBinario a)
{
    if (a != NULL)
    {        
        MostrarABBPreOrder((*a).izq);
        MostrarABBPreOrder((*a).der);
        printf("%i - %i\n",(*a).dato, (*a).cont);
    } 
}
