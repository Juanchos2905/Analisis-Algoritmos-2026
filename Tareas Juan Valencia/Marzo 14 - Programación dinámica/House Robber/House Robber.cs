public class Solution
{
    public int Rob(int[] nums)
    {
        /***
            Subproblema:
            Vamos a considerar maximoHastaCasa[i] el máximo dinero que se puede robar
            considerando las casas desde 0 hasta i.

            Recurrencia:
            En cada casa elegimos entre no robarla o robarla,
            sumándola al mejor resultado posible hasta dos casas atrás.
            maximoHastaCasa[i] =
                max(
                    maximoHastaCasa[i-1],                 // no robar casa actual
                    dineroActual + maximoHastaCasa[i-2]   // robar casa actual
                )

            Complejidad:
            Tiempo: O(n)
            Espacio: O(1)

            NOTA: No se utiliza dp porque en todos mis ejercicios trato de optimizar
            la mayor cantidad de memoria y un buen nombramiento de variables pero con
            dp sería algo como: dp[i] = max(dp[i-1], nums[i] + dp[i-2])
            que a fin de cunetas es lo que estámos empleando en este ejercicio.

            LINK: https://leetcode.com/problems/house-robber/submissions/1967047608
        ***/

        int maximoHastaDosCasasAtras = 0;
        int maximoHastaCasaAnterior = 0;

        foreach (int dineroActual in nums)
        {
            int maximoActual =
                Math.Max(
                    maximoHastaCasaAnterior,
                    dineroActual + maximoHastaDosCasasAtras
                );

            maximoHastaDosCasasAtras = maximoHastaCasaAnterior;
            maximoHastaCasaAnterior = maximoActual;
        }

        return maximoHastaCasaAnterior;
    }
}