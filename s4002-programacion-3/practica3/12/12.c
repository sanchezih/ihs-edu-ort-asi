/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/
#define N 11

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras 
/*--------------------------------------------------------------*/

//DECLARACION DEL ARBOL BINARIO DE BUSQUEDA
typedef char TCadCar[N];

typedef struct TNodoArbolBinario * TApNodoArbolBinario;

typedef struct TNodoArbolBinario{
         int cont;
         TCadCar dato;
         TApNodoArbolBinario izq;
         TApNodoArbolBinario der;
         }TNodoArbolBinario;

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerCadena(TCadCar);
void AgregarEnABB (TApNodoArbolBinario *, TCadCar);
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
      TCadCar miCadCar;
      TApNodoArbolBinario miABB;
      
      //ENCABEZADO
      printf("\nTP3-EJ12");
      printf("\n\n");
    
      //COMIENZO
      miABB = NULL;
      LeerCadena(miCadCar);
      
      while (miDato!=99)
      {
          AgregarEnABB (&miABB, miCadCar);
          LeerCadena(miCadCar);
      }
      
      if(miABB != NULL)
      {
          printf("\nLos datos ingresados en PreOrder:\n");
          MostrarABBPreOrder (miABB);
          
          printf("\n\nLos datos ingresados en InOrder:\n");
          MostrarABBInOrder (miABB);
          
          printf("\n\nLos datos ingresados en PostOrder:\n");
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
/*Funci�n  : LeerCadena
/*Prop�sito: Permite la lectura de un vector cuyos elementos  
             son ingresados por la entrada estandar.
/*Entrada  : Vector con elementos de tipo caracter.
/*Salida   : Vector con elementos de tipo caracter.
/*Pre      : -
/*Pos      : Vector actualizado con los valores ingresados.
/*--------------------------------------------------------------*/
void LeerCadena(TCadCar cad){
     
     int i;
     char car;
  
     printf("\n\nIngrese una cadena de hasta %d caracteres: \n", N-1);
     
     i = 0;     
     car = getchar();
     
     while ((i < (N - 1)) && (car != '\n')){
          cad[i] = car;
          car = getchar();
          i++;
     }
     cad[i] = '\0';
}

/*--------------------------------------------------------------*/
/*Funci�n  : AgregarEnABB
/*Prop�sito: Agregar datos a un ABB
/*Entrada  : Entero
/*Salida   : ABB
/*Pre      : -
/*Pos      : El ABB con los datos ingresados previamente
/*--------------------------------------------------------------*/
void AgregarEnABB (TApNodoArbolBinario *ABB, TCadCar cad)
{
     //VARIABLES
     TApNodoArbolBinario P;
     
     //COMIENZO
     if(*ABB == NULL)
     {
         P = (TApNodoArbolBinario) malloc(sizeof(struct TNodoArbolBinario));
         
         P->dato = cad;
         P->cont = 1;
         P->izq = NULL;
         P->der = NULL;
         *ABB = P;
     }
     else
     {
         if (dato < (*ABB)->dato)
         {
              AgregarEnABB (&(*ABB)->izq, cad);
         }
         else
         {
             if(dato > (*ABB)->dato)
             {
                 AgregarEnABB (&(*ABB)->der, cad);
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
        printf("%i   ",(*a).dato);
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
        printf("%i   ",(*a).dato);        
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
        printf("%i   ",(*a).dato);
    } 
}
