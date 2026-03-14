public class Solution
{
    /***
        Estrategia Greedy:

        Ordenamos los intervalos por su tiempo de finalización. Entonces recorremos el arreglo
        seleccionando siempre el intervalo que termina primero y si un intervalo se solapa con el anterior
        seleccionado, lo contamos como eliminado.
        
        
        Complejidad:
        Tiempo: O(n log n) (por el ordenamiento)
        Espacio: O(1) adicional

        LINK SOLUCIÓN: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/submissions/1948106824
    ***/
    public int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals.Length == 0)
            return 0;

        // Ordenar de manera ascendete.
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int totalSinCruces = 1;
        int finAnterior = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            int inicioActual = intervals[i][0];
            int finActual = intervals[i][1];

            if (inicioActual >= finAnterior)
            {
                totalSinCruces++;
                finAnterior = finActual;
            }
        }

        return intervals.Length - totalSinCruces;
    }
}