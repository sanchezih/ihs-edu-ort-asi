/*--------------------------------------------------------------*/
/*Diseñe los procedimientos y funciones necesarios que permitan
/*(SOLO EN EL ORDEN INDICADO):
/*(a) Ingresar por la entrada estándar cadenas de caracteres
/*hasta que se ingrese la cadena “Fin”. Pueden ingresarse repeticiones.
/*(b) Agregar cada cadena de caracteres a una lista doble sin
/*incluir las repeticiones.
/*(c) Mostrar recursivamente la lista doble.
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>
#include <malloc.h>
#include <stdlib.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define N 11

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
//DEFINO EL TIPO CADENA
typedef char TCadena[N];

//DEFINO EL TIPO LISTA DOBLE
typedef struct TNodoListaDoble * TApNodoListaDoble;

typedef struct TNodoListaDoble
{
        TCadena palabra;
  	    TApNodoListaDoble ant;
  	    TApNodoListaDoble sig;
}TNodoListaDoble;

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeerCadena(TCadena);
void AgregarEnListaDoble(TApNodoListaDoble*, TCadena);
void MostrarListaDoble(TApNodoListaDoble);
void GrabarPalabra(TCadena, TCadena);
void MostrarPalabra(TCadena);
int CompararCadenas( TCadena , TCadena);
int BuscarEnListaDoble(TApNodoListaDoble, TCadena);

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main()
{
    //VARIABLES
	TCadena miPalabra;
	TCadena corte;
	TApNodoListaDoble miLista;
	int res;
	int aux;

	//INICIALIZACIONES
	miLista = NULL;
	res = 0;
	aux = 0;

	//COMIENZO
	printf("Ejercicio Integrador 1\n\n");
	printf ("Ingrese una cadena para agregar a la lista doble. ""Fin"" para terminar.\n\n");
	LeerCadena(miPalabra);
	
    aux = CompararCadenas(miPalabra, "Fin");
	
    while (aux == 0)
    {
          res = BuscarEnListaDoble(miLista, miPalabra);
          if(res == 0){
          fflush(stdin);
          AgregarEnListaDoble(&miLista, miPalabra);
          }
          LeerCadena(miPalabra);
          aux = CompararCadenas(miPalabra, "Fin");
    }
	
	MostrarListaDoble (miLista);
    printf("\n\nPresione cualquier tecla para continuar...");
    getch();
    return(0);
}
	
//% VER: en las llamadas a los procedimientos y funciones, no se
//% especifica el tipo de datos.
//%/VER: "Fin" es una cadena, al igual que miPalabra, luego, no pueden
//% ser comparadas con <>,
//% debe usarse uuna función, por ejemplo CompararCadenas(miPalabra, "Fin").
	
/*--------------------------------------------------------------*/
/*Definición de otras funciones
/*--------------------------------------------------------------*/
/*--------------------------------------------------------------*/
/*Función  : LeerCadena
/*Propósito: Lee una cadena por teclado
/*Entrada  : miCadena
/*Salida   : miCadena
/*Pre      : Debe tener como maximo 10 letras
/*Pos      : Cadena actualizada con valor ingresado
/*--------------------------------------------------------------*/
void LeerCadena(TCadena miCadena)
{
     //VARIABLES
     int i;
     char car;
     
     //INICIALIZACION DE VARIABLES
     i = 0;
     
     //COMIENZO
     printf("Ingrese una cadena de hasta %d caracteres: ", N-1);     
     car = getchar();     
     while ((i < (N - 1)) && (car != '\n'))
     {
           miCadena[i] = car;
           car = getchar();
           i++;
     }     
     miCadena[i] = '\0';
}

/*--------------------------------------------------------------*/
/*Procedimiento	: AgregarEnListaDoble
/*Propósito		: Agregar palabras en una lista doble.
/*Entrada		: La lista destino y la palabra a ingresar.
/*Salida		: Lista doble.
/*Precondicion	: 
/*Postcondicion	: La lista con la palabra agregada.
/*--------------------------------------------------------------*/
void AgregarEnListaDoble(TApNodoListaDoble *lista, TCadena pal)
{
     TApNodoListaDoble p, q;
     /* malloc.h = = alloc.h */
     p=(TApNodoListaDoble) malloc(sizeof (struct TNodoListaDoble));

     GrabarPalabra(p->palabra, pal);
     
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
/*Procedimiento : MostrarListaDoble
/*Propósito		: Permite mostrar por pantalla una lista.
/*Entrada		: Lista doble.
/*Salida		: Lista doble.
/*Precondicion	: -
/*Pos			: Lista doble con los datos de sus nodos.
/*--------------------------------------------------------------*/ 
void MostrarListaDoble (TApNodoListaDoble lista)
{
     TApNodoListaDoble APAUX;
     APAUX = lista;
     
     if (APAUX != NULL)
     {
        MostrarPalabra(APAUX->palabra);
        MostrarListaDoble(APAUX->sig);
     } 
}

/*--------------------------------------------------------------*/
/*Función	: MostrarPalabra
/*Propósito	: Muestra cadenas por la salida estandar.
/*Entrada	: miPalabra
/*Salida	: -
/*Pre		: -
/*Pos		: Muestra palabra que se encuentra en un nodo.
/*--------------------------------------------------------------*/
void MostrarPalabra(TCadena miPalabra)
{
     int i;
     i=0;
     printf ("\n");
     
     while (miPalabra[i] != '\0')
     {
           putchar(miPalabra[i]);
           i=i+1;
     }
}
	
/*--------------------------------------------------------------*/
/*Funcion	: BuscarEnListaDoble
/*Propósito	: Verifica si en la lista doble, ya existe una palabra
/*que empieza con la misma letra que la que se ingreso para agregar.
/*Entrada	: palabra
/*Salida	: Entero
/*Pre		: 
/*Pos		: Retorna 1 si existe, 0 en caso contrario.
/*--------------------------------------------------------------*/ 
int BuscarEnListaDoble(  TApNodoListaDoble lista,  TCadena pal)
{

	//VARIABLES
	int existe;
	TApNodoListaDoble lis;
	
	//INICIALIZACIONES
	existe = 0;
	
	//COMIENZO
	lis = lista;
	
	while ( (lis != NULL) && (existe == 0) ){
		existe = CompararCadenas(lis->palabra, pal);
		lis = lis->sig;
	}
	
	return existe;
}
	

//% VER: aquí hay que comparar las cadenas en todos sus caracteres,
//% por ejemplo:
//% existe=CompararCadenas(lista*.dato, palabra)
//% Es decir, que existe devuelve 1 si las cadenas son iguales y 0 en caso contrario. Revisar el comentario al comenienzo del pseudo.
	
/*--------------------------------------------------------------*/
/*Funcion	: CompararCadenas
/*Propósito	: 
/*Entrada	: 
/*Salida	: 
/*Pre		: 
/*Pos		: 
/*--------------------------------------------------------------*/ 
int CompararCadenas(TCadena pal1, TCadena pal2)
{
	//VARIABLES
	int i;
	int res;
	
	//INICIALIZACIONES
	i = 0;
	res = 1;
	
	//COMIENZO

	while ( (pal1[i] != '\0') && (res==1) )
	{
		if(pal1[i] == pal2[i])
		{
			i = i+1;
      }else{
			res = 0;
        }
}
	
	if(pal2[i] != '\0'){
		res = 0;
}
	
	return res;
}

/*--------------------------------------------------------------*/
/*Procedimiento	: GrabarPalabra
/*Proposito		: Asigna una cadena a otra cadena.
/*Entrada		: palabra.
/*Salida		: palabra.
/*Precondicion	: -
/*Postcondicion	: Valor actualizado de palabraLista.
/*--------------------------------------------------------------*/
void GrabarPalabra(TCadena palabraLista,TCadena palabra)
{
     //VARIABLES
     int i;
     
     //Inicializacion de variables
     i=0;
     
     while (palabra[i]!= '\0')
     {
         palabraLista[i]=palabra[i];
         i++;
     }
     palabraLista[i]= '\0';
}
