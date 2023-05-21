/*-----------------------------------------------------------------------*/
//Dados una lista L con enlaces simples compuesta por numeros enteros y un
//valor x de tipo entero. Diseñe e implemente algoritmos que permitan:
//(a) Contar en forma iterativa la cantidad de nodos.
/*-----------------------------------------------------------------------*/
#include <stdio.h>
#include <stdlib.h>
#include "libreria_tp3.h"
/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
      int dato;
      TAPNodoListaSimple lista;
      int listaOK;
      int res;
      
//COMIENZO
      lista=NULL;
      LeerDato("Ingrese el dato: ",&dato);
      
      while (dato!=99)
      {
          AgregarAListaSimple (&lista, dato);
          LeerDato ("Ingrese el dato: ",&dato) ;
      }
      
      listaOK = VerificarLista (lista);
      if(listaOK ==1)
      {
                 res=ContarNodos(lista);
                 printf("la lista es de %i componentes",res);
      }
      else
      {
          mostrarCartel("la lista no tiene nodos");
      }

      pausa();
      return 0;
}


