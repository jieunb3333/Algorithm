def solution(array, commands):
    answer = []
    sliced_list=[]
    for com in commands:
        sliced_array=array[com[0]-1:com[1]]
        sliced_array.sort()
        answer.append(sliced_array[com[2]-1])
    return answer