import java.util.*;
// Fuerza Bruta
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

//Optimizado
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

