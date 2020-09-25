import java.util.Scanner;

public class test1 {

    public static void main (String [] args){
        Scanner in = new Scanner(System.in);
        char opcion;
        int Numero_intentos=0,Max_intentos=3;
        boolean opcion_valida;

        do{

            opciones();
            opcion= in.next().charAt(0);
            opcion= Character.toUpperCase(opcion);
            opcion_valida =validar_opcion(opcion);

            if (opcion_valida){
                System.out.println("opcion valida ");

            }else if (opcion=='C'){
                System.out.println("funcion cancelada");
                Numero_intentos=  Max_intentos;
            }else {
                Numero_intentos++;
                System.out.println("no opcion valida ");
            }

        } while ((Numero_intentos < Max_intentos) );
            System.out.println("Gracias por usar nuestro programa");
    }


    public static boolean validar_opcion(char opcion){
        boolean buscando= true;
        char [] Opciones_Validas= {'A','B'};
        for (int i=0 ;i<Opciones_Validas.length && buscando;i++){
            if (Opciones_Validas[i] == opcion){
                buscando = false;
                System.out.println(opcion);
            }
        }

        return !buscando;
    }


    public static void opciones(){
        System.out.println("Elije una opcion");
        System.out.println("A) Encriptar contraseña" );
        System.out.println("B) Desencriptar contraseña");
        System.out.println("C) Cancelar");

    }

}
