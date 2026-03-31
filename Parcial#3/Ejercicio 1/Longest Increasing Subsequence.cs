public class Solution {
    /***
        Podemos usar busqueda binaria para ubicar cada número.

        colaSubsecuencia[i] representa el menor valor posible
        que puede terminar una subsecuencia creciente de longitud i + 1.

        Complejidad:
        Tiempo: O(n log n)
        Espacio: O(n)
    ***/
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;

        List<int> colaSubsecuencia = new List<int>();

        foreach (int numeroActual in nums)
        {
            int posicion = colaSubsecuencia.BinarySearch(numeroActual);

            if (posicion < 0)
                posicion = ~posicion;

            if (posicion == colaSubsecuencia.Count)
                colaSubsecuencia.Add(numeroActual);
            else
                colaSubsecuencia[posicion] = numeroActual;
        }

        return colaSubsecuencia.Count;
    }
}