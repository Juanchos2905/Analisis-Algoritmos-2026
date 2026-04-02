public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        /***
            Subproblema:
            Haremos costoMinimoHastaEscalon[i] que nos va a indicar
            el costo mínimo necesario para llegar exactamente hasta el escalón i.

            Recurrencia:
            costoMinimoHastaEscalon[i] =
                cost[i] + min(
                    costoMinimoHastaEscalon[i-1],
                    costoMinimoHastaEscalon[i-2]
                )

            El resultado final es el mínimo entre:
                costoMinimoHastaEscalon[n-1]
                costoMinimoHastaEscalon[n-2]

            Complejidad:
            Tiempo: O(n)
            Espacio: O(n)

            LINK: https://leetcode.com/problems/min-cost-climbing-stairs/submissions/1967214915
        ***/

        int cantidadEscalones = cost.Length;

        int[] costoMinimoHastaEscalon = new int[cantidadEscalones]; //dp
        costoMinimoHastaEscalon[0] = cost[0];
        costoMinimoHastaEscalon[1] = cost[1];

        for (int indiceActual = 2; indiceActual < cantidadEscalones; indiceActual++)
        {
            costoMinimoHastaEscalon[indiceActual] =
                cost[indiceActual] +
                Math.Min(
                    costoMinimoHastaEscalon[indiceActual - 1],
                    costoMinimoHastaEscalon[indiceActual - 2]
                );
        }

        return Math.Min(
            costoMinimoHastaEscalon[cantidadEscalones - 1],
            costoMinimoHastaEscalon[cantidadEscalones - 2]
        );
    }
}