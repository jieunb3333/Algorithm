def solution(participant, completion):
    answer = ''
    hash_sum=0
    hash_dict=dict()
    # hash로 풀어보기.
    for part in participant:
        hash_dict[hash(part)] = part
        hash_sum+=hash(part)
    
    for com in completion:
        hash_sum-=hash(com)
        
        
    return hash_dict[hash_sum]