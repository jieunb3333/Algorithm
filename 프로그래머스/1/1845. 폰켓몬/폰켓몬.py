def solution(nums):
    answer = 0
    
    type = len(set(nums))
    pick_able = len(nums)//2
    
    if type > pick_able :
        answer = pick_able
    else: answer = type
    
    return answer