using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int lux=wallpaper.Length, luy=wallpaper[0].Length, rdx=0, rdy=0;
        
        // #을 감지하였을 때 lux~rdy까지 저장하기. 이 때 저장 조건은 lux,luy는 기존보다 작을 경우,  rdx와 rdy는 기존보다 클 경우 이를 갱   신한다.
        
        //wallpaper 순환하기
        int rowIndex=0;
        foreach (string file in wallpaper){
            for(int i=0;i<file.Length;i++){
                if(file[i]=='#'){
                    //파일의 끝 부분은 rowIndex:+1, i:+1
                    if(rowIndex<lux){
                        lux = rowIndex;
                    }
                    if(i<luy){
                        luy = i;
                    }
                    if(rdx<rowIndex+1){
                        rdx = rowIndex+1;
                    }
                    if(rdy<i+1){
                        rdy = i+1;
                    }
                }
            }

            rowIndex++;
            
        }
        
        int[] answer = new int[4] {lux,luy,rdx,rdy};
        return answer;
    }
}