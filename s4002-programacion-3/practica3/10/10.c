/*--------------------------------------------------------------*/
/*Programa : Ordenar Lista -Tp3-Ej10-
/*Propósito: Ordenar una lista de enlaces simples de elementos de
             tipo entero ingresada por la entrada estadar.
/*Fecha    : 27-10-07
/*Autor    : Noelia Rivarola
/*--------------------------------------------------------------*/



/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <malloc.h> 
/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef struct TNodoListaSimple * TapNodoListaSimple;

typedef struct TNodoListaSimple{
         int dato;
         TapNodoListaSimple sig;
         }TNodoListaSimple;



/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(int*);
void AgregarAListaSimple(TapNodoListaSimple *,int);
void OrdenarLista(TapNodoListaSimple*);
void MostrarListaSimple(TapNodoListaSimple);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main(){

int miDato,res;
TapNodoListaSimple miLista;

  miLista=NULL; 


              LeerDato(&miDato);
  
              while (miDato!=99){
              AgregarAListaSimple(&miLista,miDato);
             
              LeerDato(&miDato);
               }
 
 if (miLista==NULL){
      printf ("La lista está vacía");
 }
   else { 
        
        printf ("\nLa Lista en el orden de ingreso es:"); 
        MostrarListaSimple(miLista);
        OrdenarLista((&miLista));
        printf ("\nLa Lista ordenada es:"); 
        MostrarListaSimple(miLista);
   }
         
 printf("\nPresione cualquier tecla para salir...");
getch();
return 0;
}

/*--------------------------------------------------------------*/
/*Definición de otras funciones*/
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Función  : LeerNumero
/*Propósito: Lee un entero ingresado por la entrada estandar
/*Entrada  : un entero
/*Salida   : un entero
/*Pre      : -
/*Pos      : el numero que fue leido
/*--------------------------------------------------------------*/

void LeerDato(int *miNumero){
       
         printf("Ingrese un numero <99> para terminar: ", miNumero);
         scanf("%i", &(*miNumero));
}


/*--------------------------------------------------------------*/
/*Función  : AgregarAListaSimple
/*Propósito: Agregar un elemento de tipo entero, leido por la entrada
             estandar a una lista simple.
/*Entrada  : un puntero a una lista simple, y un entero
/*Salida   : lista simple 
/*Pre      : La lista debe estar inicializada.
/*Pos      : lista simple con elementos agregados.
/*--------------------------------------------------------------*/
void AgregarAListaSimple(TapNodoListaSimple *l,int miNumero){

TapNodoListaSimple p;
TapNodoListaSimple q;

p=(TapNodoListaSimple) malloc (sizeof (struct TNodoListaSimple));

       
   (*p).dato=miNumero;  
       
       if (*l==NULL){
         p->sig = NULL;                  
         *l=p;
          
       }
      
         else {
           q=*l;
           (*p).sig=q;
            *l = p;
            
           
         }
}

/*--------------------------------------------------------------*/
/*Función  : OrdenarLista
/*Propósito: Ordena los elementos de una lista simple en orden ascendente
/*Entrada  : lista simple
/*Salida   : lista simple 
/*Pre      : La lista debe tener valores para ordenar
/*Pos      : Lista simple ordenada.
/*--------------------------------------------------------------*/

void OrdenarLista(TapNodoListaSimple *l){
TapNodoListaSimple p,q;
int aux;
p=*l;

     while (p->sig!=NULL){
        q=p->sig;
          while (q!=NULL){
            if (q->dato>p->dato){
            aux=p->dato;
            p->dato=q->dato;
            q->dato=aux;
          }
          q=q->sig;
       }
     p=p->sig;
     }    
}
   
 


/*--------------------------------------------------------------*/
/*Función  : MostrarListaSimple
/*Propósito: Muestra los elementos de la lista
/*Entrada  : miLista
/*Salida   : -
/*Pre      : La lista debe tener elementos para mostrar
/*Pos      : -
/*--------------------------------------------------------------*/
     
void MostrarListaSimple(TapNodoListaSimple miLista){
TapNodoListaSimple p;
   p=miLista;
     
     if (p!=NULL){
       MostrarListaSimple((*p).sig);
       printf ("\n El ingresado numero es: %i ",p->dato); 
     }
       
}
