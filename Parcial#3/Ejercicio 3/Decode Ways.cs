public class Solution
{
    /***
        Estrategia:
        En cada posición evaluamos:

        1. Si el dígito actual es válido (1–9),
           entonces podemos extender todas las decodificaciones anteriores.

        2. Si los dos últimos dígitos forman un número entre 10 y 26,
           entonces podemos sumar también las formas de hace dos posiciones.

        Complejidad:
        Tiempo: O(n)
        Espacio: O(1)

        LINK SOLUCIÓN: https://leetcode.com/problems/decode-ways/submissions/1963005035/
    ***/
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;

        int formasHastaDosAnteriores = 1; // Caso para cuando sea vacío
        int formasHastaAnterior = 1;      // Primer carácter válido

        for (int posicionActual = 1; posicionActual < s.Length; posicionActual++)
        {
            int formasEnPosicionActual = 0;

            // Evaluar decodificación de un solo dígito
            if (s[posicionActual] != '0')
            {
                formasEnPosicionActual += formasHastaAnterior;
            }

            // Evaluar decodificación de dos dígitos
            int valorDosDigitos =
                (s[posicionActual - 1] - '0') * 10 +
                (s[posicionActual] - '0');

            if (valorDosDigitos >= 10 && valorDosDigitos <= 26)
            {
                formasEnPosicionActual += formasHastaDosAnteriores;
            }

            // Si en algún punto no hay forma válida
            if (formasEnPosicionActual == 0)
                return 0;

            formasHastaDosAnteriores = formasHastaAnterior;
            formasHastaAnterior = formasEnPosicionActual;
        }

        return formasHastaAnterior;
    }
}