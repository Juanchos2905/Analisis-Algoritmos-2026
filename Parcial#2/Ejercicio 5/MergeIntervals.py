from typing import List

class Solution:
    def merge(self, arr: List[List[int]]) -> List[List[int]]:

        arr.sort(key=lambda x: x[0])
        
        res = []
        for i in arr:
            if not res or res[-1][1] < i[0]:
                res.append(i)
            else:
                res[-1][1] = max(res[-1][1], i[1])
                
        return res


if __name__ == "__main__":
    sol = Solution()
    ejemplo = [[1, 3], [2, 6], [8, 10], [15, 18]]
    print(f"Intervalos fusionados: {sol.merge(ejemplo)}")
