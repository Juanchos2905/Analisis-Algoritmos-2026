//https://leetcode.com/problems/jump-game/submissions/1947085367

public class Solution {

    /*
    PROBLEMA:
    Se nos da un arreglo de enteros llamado nums. Cada posición del arreglo
    representa la distancia máxima que podemos saltar desde ese índice.

    Comenzamos en el índice 0 y debemos determinar si es posible llegar
    hasta el último índice del arreglo.

    EJEMPLO:
    nums = [2,3,1,1,4]

    Desde el índice 0 podemos saltar hasta 2 posiciones.
    Luego desde el índice 1 podemos saltar 3 posiciones y llegar al final.
    Por lo tanto el resultado sería true.

    ---------------------------------------------------------------------

    JUSTIFICACIÓN DEL MÉTODO GREEDY:

    Este problema se puede resolver usando un enfoque Greedy (codicioso).
    La idea principal es mantener siempre el índice más lejano que podemos
    alcanzar mientras recorremos el arreglo.

    En cada posición i calculamos hasta dónde podemos llegar desde ahí:
        i + nums[i]

    Si este valor es mayor que el alcance máximo actual, lo actualizamos.

    Si en algún momento encontramos un índice i que es mayor que el alcance
    máximo que tenemos guardado, significa que no podemos llegar a esa
    posición desde ningún salto anterior, por lo tanto es imposible
    llegar al final del arreglo.

    Este método es Greedy porque en cada paso tomamos la mejor decisión
    local posible: mantener siempre el mayor alcance disponible.

    ---------------------------------------------------------------------

    ANÁLISIS DE COMPLEJIDAD:

    Complejidad temporal: O(n)
    El algoritmo recorre el arreglo una sola vez.

    Complejidad espacial: O(1)
    Solo utilizamos una variable adicional (maxReach), por lo que
    el espacio usado no depende del tamaño del arreglo.
    */

    public static boolean canJump(int[] nums) {

        // Variable que guarda la posición más lejana que podemos alcanzar
        int maxReach = 0;

        // Recorremos el arreglo
        for (int i = 0; i < nums.length; i++) {

            // Si el índice actual es mayor que el alcance máximo
            // significa que no podemos llegar a esta posición
            if (i > maxReach) {
                return false;
            }

            // Actualizamos el alcance máximo posible
            maxReach = Math.max(maxReach, i + nums[i]);

            // Si ya podemos llegar al último índice
            if (maxReach >= nums.length - 1) {
                return true;
            }
        }

        // Si terminamos el recorrido significa que sí podemos llegar al final
        return true;
    }

}
