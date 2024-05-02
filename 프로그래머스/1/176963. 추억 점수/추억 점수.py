def solution(name, yearning, photo):
    answer = []
    score_dict = dict()
    
    for i in range(len(yearning)):
        score_dict[name[i]] = yearning[i]
    
    for onepiece in photo:
        sum = 0
        for humen in onepiece:
            
            if humen in score_dict:
                sum+=score_dict[humen]
        answer.append(sum)
        
    return answer