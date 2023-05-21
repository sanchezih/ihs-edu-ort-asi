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
typedef struct TNodoListaSimple *TAPNodoListaSimple;
typedef struct TNodoListaSimple {
                                   int dato;
                                   TAPNodoListaSimple sig;
                                 }TNodoListaSimple ;

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerDato(string, int*);
void AgregarAListaSimple (TAPNodoListaSimple *, int);
void mostrarListaSimple (TAPNodoListaSimple);
void mostrarCartel(string);
void pausa();
int VerificarLista (TAPNodoListaSimple);
int ContarNodos(TAPNodoListaSimple);
