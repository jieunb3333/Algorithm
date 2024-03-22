def solution(s):
    answer = 0
    first_alpha = ''
    first = 0
    other = 0
    index = 0
    for alpha in s:
        index+=1
        if(first==0):
            first_alpha=alpha
            first+=1
        elif(first_alpha==alpha):
            first+=1
        else:
            other+=1
            
        print(first, other)
        
        if(first==other):         
            first = 0
            other=0
            first_alpha=''
            answer+=1

                    
        if((index==len(s)) and first!=other):
            answer+=1
        print(answer)
            
    return answer