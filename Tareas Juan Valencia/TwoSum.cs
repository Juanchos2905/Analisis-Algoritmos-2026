public class Solution {
    /***
        Estrategia:
        Se me ocurrió utilizar algebra de la siguiente manera: x + ? = target
        cosa que despejando nos quedaría target - x = ? que en palabras cristianas es
        al restar el número deseado con un número cualquiera nos da como resultado lo que me falta 
        para encontrar el target, por lo que utilizando un diccionario y un for lograremos cumplir
        con el objetivo.

        Complejidad: O(n)
     
        Es más óptima que O(n²) porque evitamos el doble bucle
        utilizando una estructura de acceso en tiempo constante (Dictionary).

        Adicionalmente si no se encuentran números que den con la solución se retorna un arreglo vacío pero también
        se podría retornar un mensaje de error si se desea.
    ***/
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int numEvaluar = target - nums[i];

            if (map.ContainsKey(numEvaluar)){
                return new int[] { map[numEvaluar], i};
            }

            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}