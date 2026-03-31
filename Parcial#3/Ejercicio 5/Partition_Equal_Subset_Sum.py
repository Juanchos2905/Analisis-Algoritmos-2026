from typing import List

class Solution:
    def canPartition(self, nums: List[int]) -> bool:
        """
        Estrategia:
        Si la suma total es impar, no se puede dividir en partes iguales.
        Entonces podemo ver el problama de la siguiente manera:
        ¿Existe un subconjunto cuya suma sea total / 2?
        

        Complejidad:
        Tiempo: O(n * suma_objetivo)
        Espacio: O(suma_objetivo)
        """
        suma_total = sum(nums)

        # Si la suma total es impar, no puede dividirse en partes iguales
        if suma_total % 2 != 0:
            return False

        suma_objetivo = suma_total // 2

        # suma_alcanzable[i] indica si es posible formar la suma i
        suma_alcanzable = [False] * (suma_objetivo + 1)
        suma_alcanzable[0] = True  # Siempre podemos formar suma 0

        for numero_actual in nums:
            # Recorremos hacia atrás para evitar reutilizar el mismo número
            for suma_en_evaluacion in range(
                suma_objetivo, 
                numero_actual - 1, 
                -1
            ):
                suma_alcanzable[suma_en_evaluacion] = (
                    suma_alcanzable[suma_en_evaluacion]
                    or
                    suma_alcanzable[suma_en_evaluacion - numero_actual]
                )

        return suma_alcanzable[suma_objetivo]
