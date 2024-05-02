def solution(s, skip, index):
    alpha = 'abcdefghijklmnopqrstuvwxyz'

    for i in skip:
        alpha=alpha.replace(i,'')
    print(alpha)
        
    new_word=""
    for j in s:
        new_word+=alpha[(alpha.find(j)+index)%len(alpha)]
    
    return new_word