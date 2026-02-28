import java.util.*;
/*
* Fuerza Bruta
* Complejidad:
* Tiempo: O(n)
* Aunque hay dos for, el segundo realmente solo se ejecuta una vez
* por cada iteración del primero (j = i + 1). Por lo tanto,
* el número total de comparaciones es n - 1.
*
* Espacio: O(1)
* Solo se usan variables primitivas (count, n, etc.),
* no se crean estructuras adicionales dependientes de n.
*/
public class Stones {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String s = sc.next();
        
        int count = 0;
        
        for(int i = 0; i < n - 1; i++) {
            for(int j = i + 1; j <= i + 1; j++) {  // innecesario pero fuerza estructura doble
                if(s.charAt(i) == s.charAt(j)) {
                    count++;
                }
            }
        }
        
        System.out.println(count);
    }
}

/*
* Optimizado
* Complejidad:
* Tiempo: O(n)
* Se recorre la cadena una sola vez comparando cada
* carácter con el anterior.
* 
* Espacio: O(1)
* Solo se utiliza una variable auxiliar (z)
* y un contador. No depende del tamaño de entrada.
*/
public class Stones{
    public static void main(String[] arg){
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String s = sc.next();
        int count = 0;
        char z = s.charAt(0);
        
        for(int i = 1; i < n; i++){
            if(z == s.charAt(i)){
                count++;
            }
            z = s.charAt(i);
        }
        System.out.println(count);
    }
}


