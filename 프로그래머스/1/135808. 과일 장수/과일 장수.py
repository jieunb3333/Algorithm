def solution(k, m, score):

    list = []
    score.sort(reverse=True)
    
    for i in range(0,len(score),m):
        if(i+m<len(score)+1):
            list.append(score[i:i+m])
            
    apple_price_sum = 0
    for apple in list:
        apple_price_sum += min(apple)*m
        
    
    return apple_price_sum