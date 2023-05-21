/*
  Name: Ignacio Sanchez
  Copyright: 
  Author: 
  Date: 04/11/07 21:15
  Description: Comparar dos ABB en contenido y estructura
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
int CompararArboles (TApNodoArbolBinario, TApNodoArbolBinario);
void MostrarABBPreOrder (TApNodoArbolBinario);

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
      //VARIABLES
      TApNodoArbolBinario miABB;
      TApNodoArbolBinario miABB2;
      int miDato;
      int res;
      
      //ENCABEZADO
      printf("\nTP3 - Ejercicio 18");
      printf("\nComparar 2 arboles binarios, en contenido y estructura");
      printf("\n------------------------------------------------------");
      printf("\n\n");
    
      //COMIENZO
      miABB = NULL;
      
      printf("Ingrese los datos para el primer ABB\n");
      printf("------------------------------------\n");
      LeerDato(&miDato);      
      
      while (miDato!=99)
      {
          AgregarEnABB (&miABB, miDato);
          LeerDato(&miDato);
      }
        
      miABB2 = NULL;
      
      printf("\nIngrese los datos para el segundo ABB\n");
      printf("-------------------------------------\n");  
      LeerDato(&miDato);
      
      while (miDato!=99)
      {
          AgregarEnABB (&miABB2, miDato);
          LeerDato(&miDato);
      }
      
      MostrarABBPreOrder (miABB);
      printf("\n");
      MostrarABBPreOrder (miABB2);
      res = CompararArboles(miABB, miABB2);
      
      if(res == 1)
      {
          printf("\nLos ABB son iguales\n");
      }
      else
      {
          printf("\nLos ABB no son iguales");
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
/*Función  : CompararArboles
/*Propósito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : -
/*Pos      : 
/*--------------------------------------------------------------*/
int CompararArboles (TApNodoArbolBinario ABB, TApNodoArbolBinario ABB2)
{
     //VARIABLES
     int res;
     res = 0;
     
     //COMIENZO
     if( (ABB)== NULL && (ABB2)== NULL )
     {
         res = 1;
     }
     else
     {
         if( ( ((ABB)== NULL) && ((ABB2)!= NULL) ) || ( ((ABB)!= NULL) && ((ABB2)== NULL) ) )
         {
             res = 0;
         }
         else
         {
             if( ((ABB)->dato) != ((ABB2)->dato) )
             {
                 res = 0;
             }
             else
             {
                 res = CompararArboles( ABB->izq, ABB2->izq) && CompararArboles( ABB->der, ABB2->der);
             }
         }
     }
     return (res);
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
        printf("%i\n",(*a).dato);
        MostrarABBPreOrder((*a).izq);
        MostrarABBPreOrder((*a).der);
    } 
}
