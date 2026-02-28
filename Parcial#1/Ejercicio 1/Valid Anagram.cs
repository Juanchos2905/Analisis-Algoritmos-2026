public class Solution {
    public bool IsAnagram(string s, string t) {
            /***
                Solución "Fuerza Bruta":
                Acá se pone en práctica ordenar ambas cadenas y luego las comparamos.
                
                Complejidad:
                Tiempo: O(n log n)
                Espacio: O(n)
             ***/

        if (s.Length != t.Length)
            return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        /***
            Solución "Optimizada":
            Usamos un arreglo de tamaño fijo, en este caso de 26.

            Recorremos s sumando ocurrencias.
            Recorremos t restando ocurrencias.
            
            Si al final todo es 0 → es anagrama.
            
            Complejidad:
            Tiempo: O(n)
            Espacio: O(1) (porque 26 es constante)
        ***/

        if (s.Length != t.Length)
            return false;

        int[] contadorLetras = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            contadorLetras[s[i] - 'a']++;
            contadorLetras[t[i] - 'a']--;
        }

        foreach (int conteo in contadorLetras)
        {
            if (conteo != 0)
                return false;
        }

        return true;
    }
}