import java.util.*;

public class WordBreak {
    public static boolean wordBreak(String s, List<String> wordDict) {

        // paso el diccionario a HashSet para buscar rápido (O(1))
        Set<String> wordSet = new HashSet<>(wordDict);

        // dp[i] significa: ¿puedo formar la cadena desde 0 hasta i?
        boolean[] dp = new boolean[s.length() + 1];

        // una cadena vacía siempre se puede formar
        dp[0] = true;

        // Vamos construyendo la solución poco a poco (de izquierda a derecha)
        for (int i = 1; i <= s.length(); i++) {

            // Probamos todos los cortes posibles antes de i
            for (int j = 0; j < i; j++) {

                // Si ya pude formar hasta j, y lo que sigue (j -> i) es una palabra válida
                if (dp[j] && wordSet.contains(s.substring(j, i))) {
                    dp[i] = true; // entonces sí puedo formar hasta i
                    break; // ya no necesito seguir probando más cortes
                }
            }
        }

        // Devuelvo si se pudo formar toda la cadena
        return dp[s.length()];

        /*
         Complejidad:

         Tiempo: O(n^2)
         - Dos ciclos anidados (i y j)
         - substring puede costar hasta O(n), pero en la práctica se considera O(1) amortizado

         Espacio: O(n)
         - Solo usamos el arreglo dp

         https://leetcode.com/problems/word-break/submissions/1965337596
         */
    }
}