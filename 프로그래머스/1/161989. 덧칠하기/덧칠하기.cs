using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        //section에서 첫번째 원소를 기준으로 + m-1까지 칠하기 가능. section을 돌면서 한 번 칠할 수 있는 마지막 section 저장해두기. 마지막 section 보다 큰 곳 발생하면 answer + 1 하고 그 원소 기준으로 마지막 section 갱신.
        int lastSection = 0;
        int painted = 0;
        foreach (int a in section){
            if(lastSection<a){
                lastSection = a+m-1; // 칠할 수 있는 마지막 원소 갱신.
                painted++;
                
            }    
            
        }
                
        int answer = painted;
        return answer;
    }
}