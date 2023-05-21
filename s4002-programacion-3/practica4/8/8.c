/*--------------------------------------------------------------*/
/*Programa : Ejemplo8.c
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusi�n de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaraci�n de constantes y macros
/*--------------------------------------------------------------*/
#define dimLin 80
#define dimCad 20

/*--------------------------------------------------------------*/
/*Declaraci�n de estructuras
/*--------------------------------------------------------------*/
typedef char TLinea[dimLin];
typedef char TCadena[dimCad];
typedef FILE* TArchivo;

/*--------------------------------------------------------------*/
/*Declaraci�n de prototipos de funciones
/*--------------------------------------------------------------*/
void LeeryEscribirTexto(TArchivo, TArchivo, int);
void IniciarLinea(TLinea);
void LeerLinea(TArchivo, TLinea, char);
void EscribirLinea(TArchivo, TLinea);
void LeerDato(int*);
int LongitudDeLinea(TLinea);

/*--------------------------------------------------------------*/
/*Declaraci�n de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definici�n de la funci�n principal
/*--------------------------------------------------------------*/
int main(){

    TCadena miNombreOri;
    TCadena miNombreDes;
    TArchivo miOri;
    TArchivo miDes;
    int n;
    char c;
    int xx;
    
    printf("Ejercicio 8 - TP4\n\n");    
    printf("Ingrese la ruta del archivo origen: ");
    scanf("%s", miNombreOri);
    printf("Ingrese la ruta del archivo destino: ");
    scanf("%s", miNombreDes);

    miOri = fopen(miNombreOri, "rt");
    if (miOri == NULL){
        printf("No se puede abrir el archivo origen");
        getch();
        return(1);
    }
    else{
         miDes = fopen(miNombreDes, "wt");
         if (miDes == NULL){
	         printf("No se puede abrir el archivo destino");
             fclose(miOri);
  	         getch();
   	         return(1);
	     }
         else{
              fflush(stdin);
              LeerDato(&n);
                            
 	          LeeryEscribirTexto(miOri, miDes, n);
              printf("\nFin de proceso!");
              fclose(miOri);
              fclose(miDes);
              printf("\n\nPresione cualquier tecla para continuar...");
              getch();
              return(0);
        }
   }
}

/*--------------------------------------------------------------*/
/*Funci�n  : LeeryEscribirTexto
/*Prop�sito: permite leer las l�neas de un archivo de texto y 
             escribirlas en otro archivo de texto
/*Entrada  : archivo de texto origen y archivo de texto destino
/*Salida   : archivo de texto destino
/*Pre      : -
/*Pos      : archivo destino actualizado con las l�neas del 
             archivo origen    
/*--- -----------------------------------------------------------*/             
void LeeryEscribirTexto(TArchivo ori, TArchivo des, int n){

	 TLinea l;
	 char c;
	 int longi;

  	 c = fgetc(ori);
	 while(!feof(ori)){
	       IniciarLinea(l);
	       LeerLinea(ori, l, c);
	       longi = LongitudDeLinea(l);
	       if(longi <= n)
	       {
                EscribirLinea(des, l);
           }
	       c = fgetc(ori);
     }
}

/*--------------------------------------------------------------*/
/*Funci�n  : IniciarLinea
/*Prop�sito: permite iniciar una l�nea con el car�cter blanco
/*Entrada  : vector de caracteres que representa la l�nea
/*Salida   : vector de caracteres que representa la l�nea
/*Pre      : -
/*Pos      : vector con blancos asignados en sus posiciones
/*--------------------------------------------------------------*/
void IniciarLinea(TLinea l){

     int i;

     for(i=0; i < dimLin; i++)
    	 l[i] = ' ';
}

/*--------------------------------------------------------------*/
/*Funci�n  : LeerLinea
/*Prop�sito: permite asignar a un vector los caracteres de una 
             l�nea de un archivo de texto
/*Entrada  : archivo de texto origen, l�nea para almacenar los
             caracteres, caracter
/*Salida   : l�nea del archivo de texto
/*Pre      : l�nea iniciada, primer car�cter de la l�nea le�da
/*Pos      : l�nea actualizada con car�cter \n (EOL)   
/*--------------------------------------------------------------*/
void LeerLinea(TArchivo arch, TLinea lin, char car){

     int i;

     i=0;

     while (car != '\n'){
	        lin[i] = car;
      	    car = fgetc(arch);
   	        i++;
	 }

	 lin[i] = car;
}

/*--------------------------------------------------------------*/
/*Funci�n  : EscribirLinea
/*Prop�sito: permite escribir una l�nea en un archivo de texto
/*Entrada  : archivo de texto destino, linea que contiene los
             caracteres a escribir
/*Salida   : archivo de texto
/*Pre      : - 
/*Pos      : archivo de texto actualizado con la l�nea 
/*--------------------------------------------------------------*/
void EscribirLinea(TArchivo arch, TLinea lin){

     int i;

     i=0;

     while (lin[i] != '\n'){
	        fputc(lin[i], arch);
  	        i++;
    }
	fputc(lin[i], arch);
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
       
         printf("Ingrese un entero (<= a la linea mas corta del archivo): ", miNumero);
         scanf("%i", &(*miNumero));
}

/*--------------------------------------------------------------*/
/*Funci�n  : LongitudDeLinea
/*Prop�sito: 
/*Entrada  : 
/*Salida   : 
/*Pre      : -
/*Pos      : 
/*--------------------------------------------------------------*/

int LongitudDeLinea(TLinea laLinea)
{
    //VARIABLES
    int cant = 0;
    int i = 0;
    
    //COMIENZO
    while(laLinea[i] != '\n')
    {
         cant = cant + 1;
         i++;
    }
    return cant;
}
