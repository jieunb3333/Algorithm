using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string temp="";
        var DicPlayers = new Dictionary<string, int>();

        for (int i=0;i<players.Length;i++){
            DicPlayers[players[i]]=i;
        }
        
        foreach(string c in callings){
            int index = DicPlayers[c];
            DicPlayers[c]--;
            DicPlayers[players[index-1]]++;
            temp=players[index-1];
            players[index-1]=players[index];
            players[index]=temp;
        }
        string[] answer = new string[] {};
        
        answer = players;
        
        return answer;
    }
}