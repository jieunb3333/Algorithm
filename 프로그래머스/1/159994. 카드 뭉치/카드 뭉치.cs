using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        //dictionary에 cards1, cards2를 각 인덱스와 함께 저장. goal 각각에 접근하여 cards1, cards2 중 하나라도 있으면 현재 움직이고 있는 index (cards1Turn, cards2Turns와 비교한다. 만약 해당 인덱스 보다 Dictionary의 value(Index) 값이 작은 것이 하나라도 발견되면 "No" 출력)
        
        Dictionary<String, int> cardsDic1 = new Dictionary<String, int>();
        Dictionary<String, int> cardsDic2 = new Dictionary<String, int>();
        
        for (int i=0;i<cards1.Length;i++){
            cardsDic1.Add(cards1[i],i);
        }
        for (int j=0;j<cards2.Length;j++){
            cardsDic2.Add(cards2[j],j);
        }
        
        int cards1Turn = 0;
        int cards2Turn = 0;
        
        string answer = "";
        
        foreach (String voca in goal){
            if(cardsDic1.ContainsKey(voca)){
                if(cards1Turn<cardsDic1[voca]){
                    answer = "No";
                    break;
                }
                else{
                    cards1Turn++;
                }
            }
            else if(cardsDic2.ContainsKey(voca)){
                if(cards2Turn<cardsDic2[voca]){
                    answer = "No";
                    break;
                }
                else{
                    cards2Turn++;
                }
            }
            else{
                answer = "No";
                break;
            }
            
            if(voca==goal[goal.Length-1]){
                answer = "Yes";
            }
        }
            
        
        return answer;
    }
}