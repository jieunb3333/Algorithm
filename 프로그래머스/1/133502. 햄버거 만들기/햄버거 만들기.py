def solution(ingredient):
    list =[]
    cnt = 0
    for i in ingredient:
        list.append(i)
        if list[-4:] == [1,2,3,1]:
            cnt+=1
            for _ in range(4):
                list.pop()
                
    
    return cnt