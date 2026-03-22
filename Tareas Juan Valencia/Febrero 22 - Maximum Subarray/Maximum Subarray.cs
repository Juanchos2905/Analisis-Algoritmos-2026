public class Solution {
    public int MaxSubArray(int[] nums) {
        /***    
            Se recorre el arreglo una sola vez y en cada posición se decide si conviene
            continuar el subarreglo actual sumando el elemento que se está evaluando o 
            empezar uno nuevo desde ese mismo punto. Durante este proceso se va llevando un 
            seguimiento de la suma actual, que representa la mejor suma posible de un subarreglo
            que termina en esa posición, y de la suma máxima, que corresponde a la mejor suma 
            encontrada en todo el arreglo hasta ese momento.
        
            Complejidad:
            Tiempo: O(n)
            Espacio: O(1)

            LINK: https://leetcode.com/problems/maximum-subarray/submissions/1956161900
        ***/

        int sumaActual = nums[0];
        int sumaMaxima = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sumaActual = Math.Max(nums[i], sumaActual + nums[i]);
            sumaMaxima = Math.Max(sumaMaxima, sumaActual);
        }

        return sumaMaxima;
    }
}