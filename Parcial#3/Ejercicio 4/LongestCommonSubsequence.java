public class LongestCommonSubsequence {
    public int longestCommonSubsequence(String text1, String text2) {

        int n = text1.length();
        int m = text2.length();

        // dp[i][j] significa:
        // la longitud de la subsecuencia común más larga
        // entre text1[0:i] y text2[0:j]
        int[][] dp = new int[n + 1][m + 1];

        // Caso base:
        // dp[0][j] = 0 y dp[i][0] = 0
        // porque si una cadena está vacía, no hay subsecuencia común

        // Llenamos la tabla poco a poco (fila por fila)
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= m; j++) {

                // Si los caracteres coinciden
                if (text1.charAt(i - 1) == text2.charAt(j - 1)) {

                    // Sumamos 1 a lo que ya teníamos antes
                    dp[i][j] = dp[i - 1][j - 1] + 1;

                } else {
                    // Si no coinciden, tomamos el mejor resultado previo
                    dp[i][j] = Math.max(dp[i - 1][j], dp[i][j - 1]);
                }
            }
        }

        // Resultado final: esquina inferior derecha
        return dp[n][m];

        /*
         Complejidad:

         Tiempo: O(n * m)
         - Recorremos toda la matriz

         Espacio: O(n * m)
         - Usamos una matriz 2D

        https://leetcode.com/problems/longest-common-subsequence/submissions/1965344841
         */
    }
}
