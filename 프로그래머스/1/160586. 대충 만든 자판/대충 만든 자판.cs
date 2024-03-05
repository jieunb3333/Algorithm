using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        //알고리즘 구상
        //keymap을 순환하면서 새로운 문자가 등장했을 때 Dictionary에 key(문자):value(최소 몇번의 클릭으로 접근가능한가)를 저장한다. 그리고 순환문 내부에서 조건문을 사용하여 현재의 value보다 새로운 최소 클릭 횟수가 등장하면 갱신해준다.
        Dictionary<char,int> minClick= new Dictionary<char,int>();
        foreach (string sentence in keymap){
            int count=0; //클릭한 값.
            foreach(char key in sentence){
                count++; 
                if (minClick.ContainsKey(key)){
                    if(minClick[key]>count){
                        minClick[key]=count;
                    }
                }
                else {
                    minClick.Add(key,count);
                }
                
            }   
        }
        
        int[] result = new int[targets.Length]; 
        int index = 0;
        
        foreach(string target in targets){
            
            int min_click_count=0;
            foreach(char one in target){
                if(minClick.ContainsKey(one)){
                    min_click_count+=minClick[one];
                }
                else{
                    min_click_count=-1;
                    break;
                    
                }
            }
            result[index] = min_click_count;
            index++;
        }
        
        int[] answer = result; //keymap만큼의 배열이 있을 것.
        return answer;
    }
}