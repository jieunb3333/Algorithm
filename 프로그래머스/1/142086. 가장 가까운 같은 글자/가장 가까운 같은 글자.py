def solution(s):
    answer = []
    s_dic={}
    
    for i in range(0,len(s)):
        
        if(s[i] in s_dic):
            answer.append(i-s_dic[s[i]])
            s_dic[s[i]]=i
        else:
            answer.append(-1)
            s_dic[s[i]]=i
            
    
    
    return answer