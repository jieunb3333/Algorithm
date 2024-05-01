def solution(numbers, target):
    answer = 0
    n = len(numbers)
    
    def bfs(idx,result):
    
        if(idx==n):
            if(result==target):
                nonlocal answer
                answer += 1
            return
        else:
            bfs(idx+1,result+numbers[idx])
            bfs(idx+1,result-numbers[idx])
        
    bfs(0,0)
    
    
    return answer