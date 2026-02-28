class Solution:
        #Complejidad Temporal: O(n) - Itera una sola vez por la lista.
        #Complejidad Espacial: O(1) - Usa memoria constante para las variables.
    def maxProfit(self, prices: list[int]) -> int:
        
        min_price = float('inf')
        max_profit = 0
        
        for price in prices:

            if price < min_price:
                min_price = price
  
            elif price - min_price > max_profit:
                max_profit = price - min_price
                
        return max_profit
