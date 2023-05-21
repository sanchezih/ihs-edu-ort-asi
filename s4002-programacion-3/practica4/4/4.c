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
void LeeryEscribirTexto(TArchivo, TArchivo);
void IniciarLinea(TLinea);
void LeerLinea(TArchivo, TLinea, char);
void EscribirLinea(TArchivo, TLinea);
void invertirCadenas(TLinea);

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

    printf("Ingrese ruta del archivo origen: \n");
    scanf("%s", miNombreOri);
    printf("Ingrese ruta del archivo destino: \n");
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
 	          LeeryEscribirTexto(miOri, miDes);
              printf("Fin de proceso!");
              fclose(miOri);
              fclose(miDes);
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
void LeeryEscribirTexto(TArchivo ori, TArchivo des){

	 TLinea l;
	 char c;

  	 c = fgetc(ori);
	 while(!feof(ori)){
	       IniciarLinea(l);
	       LeerLinea(ori, l, c);
	       invertirCadenas(l);
	       EscribirLinea(des, l);
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

/*-------------------------------------------------------------
*  invertir Cadenas
--------------------------------------------------------------*/
void invertirCadenas(TLinea lin)
{
     TLinea cadena2;
     
     int contador=0, medio, longitud;
     int i=0;
     
     
     while (lin[i] != '\0')
     {
       contador=contador+1;
       i++;
     }
     longitud=contador;
     
     for (i=0;i<longitud;i++)
     {
         contador=contador-1;
         cadena2[contador]=lin[i];
     }
     
     cadena2[longitud]='\0';
}
