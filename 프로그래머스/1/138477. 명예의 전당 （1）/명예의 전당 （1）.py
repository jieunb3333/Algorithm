def solution(k, score):
    list_top = []
    index=0
    answer = []
    for i in score :
        if(index<k):
            list_top.append(i)
        else:
            if(min(list_top)<i):
                list_top.remove(min(list_top))
                list_top.append(i)
            
        answer.append(min(list_top))
        
        index+=1
    
    

    return answer