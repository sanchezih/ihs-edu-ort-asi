/*--------------------------------------------------------------*/
/*Programa : Ejemplo10.c
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Inclusión de archivos
/*--------------------------------------------------------------*/
#include <stdio.h>
#include <conio.h>

/*--------------------------------------------------------------*/
/*Declaración de constantes y macros
/*--------------------------------------------------------------*/
#define dimLin 80
#define dimCad 20

/*--------------------------------------------------------------*/
/*Declaración de estructuras
/*--------------------------------------------------------------*/
typedef char TLinea[dimLin];
typedef char TCadena[dimCad];
typedef FILE* TArchivo;

/*--------------------------------------------------------------*/
/*Declaración de prototipos de funciones
/*--------------------------------------------------------------*/
void LeeryEscribirTexto(TArchivo, TArchivo, int);
void IniciarLinea(TLinea);
void LeerLinea(TArchivo, TLinea, char);
void EscribirLinea(TArchivo, TLinea, int);
void LeerDato(int*);

/*--------------------------------------------------------------*/
/*Declaración de variables globales
/*--------------------------------------------------------------*/

/*--------------------------------------------------------------*/
/*Definición de la función principal
/*--------------------------------------------------------------*/
int main(){

    TCadena miNombreOri;
    TCadena miNombreDes;
    TArchivo miOri;
    TArchivo miDes;
    int n;
    char c;
    TCadena a = "33";
    int xx;
    
    xx=atoi(a);
    printf("%i\n\n\n", xx);
    printf("Ejercicio 10 - TP4\n\n");    
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
/*Función  : LeeryEscribirTexto
/*Propósito: permite leer las líneas de un archivo de texto y 
             escribirlas en otro archivo de texto
/*Entrada  : archivo de texto origen y archivo de texto destino
/*Salida   : archivo de texto destino
/*Pre      : -
/*Pos      : archivo destino actualizado con las líneas del 
             archivo origen    
/*--- -----------------------------------------------------------*/             
void LeeryEscribirTexto(TArchivo ori, TArchivo des, int n){

	 TLinea l;
	 char c;

  	 c = fgetc(ori);
	 while(!feof(ori)){
	       IniciarLinea(l);
	       LeerLinea(ori, l, c);
	       EscribirLinea(des, l, n);
	       c = fgetc(ori);
	       }
}

/*--------------------------------------------------------------*/
/*Función  : IniciarLinea
/*Propósito: permite iniciar una línea con el carácter blanco
/*Entrada  : vector de caracteres que representa la línea
/*Salida   : vector de caracteres que representa la línea
/*Pre      : -
/*Pos      : vector con blancos asignados en sus posiciones
/*--------------------------------------------------------------*/
void IniciarLinea(TLinea l){

     int i;

     for(i=0; i < dimLin; i++)
    	 l[i] = ' ';
}

/*--------------------------------------------------------------*/
/*Función  : LeerLinea
/*Propósito: permite asignar a un vector los caracteres de una 
             línea de un archivo de texto
/*Entrada  : archivo de texto origen, línea para almacenar los
             caracteres, caracter
/*Salida   : línea del archivo de texto
/*Pre      : línea iniciada, primer carácter de la línea leída
/*Pos      : línea actualizada con carácter \n (EOL)   
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
/*Función  : EscribirLinea
/*Propósito: permite escribir una línea en un archivo de texto
/*Entrada  : archivo de texto destino, linea que contiene los
             caracteres a escribir
/*Salida   : archivo de texto
/*Pre      : - 
/*Pos      : archivo de texto actualizado con la línea 
/*--------------------------------------------------------------*/
void EscribirLinea(TArchivo arch, TLinea lin, int n){

     int i;

     i=0;

     while (lin[n] != '\n'){
	        fputc(lin[n], arch);
  	        n++;
    }
	fputc(lin[n], arch);
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
       
         printf("Ingrese un entero (<= a la linea mas corta del archivo): ", miNumero);
         scanf("%i", &(*miNumero));
}
