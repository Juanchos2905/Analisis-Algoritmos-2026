/*
* Fuerza bruta
*
* Complejidad
* Tiempo: O(log n) porque se ordena el arreglo.
* Luego se recorre una vez O(n).
* La complejidad final es O(log n).
*
* Espacio: O(1) porque no usamos estructuras adicionales.
*/
class Solution {
    public boolean containsDuplicate(int[] nums) {
        Arrays.sort(nums);
        for (int i = 0; i < nums.length-1; i++){
            if (nums[i] == nums[i+1]){
                return true;
            }
        } 
        return false;
    }
}

/*
* Optimizado
* Complejidad:
* Tiempo: O(n) porque recorremos el arreglo una sola vez.
* Espacio: O(n) porque guardamos los elementos en un HashSet.
*/
class Solution {
    public boolean containsDuplicate(int[] nums) {
        HashSet<Integer> set = new HashSet<>();
        for (int num: nums){
            if (set.contains(num)) return true;
            set.add(num);
        }
        return false;
    }

}
