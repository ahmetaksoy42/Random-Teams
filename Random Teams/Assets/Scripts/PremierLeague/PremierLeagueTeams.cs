using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PremierLeagueTeams : MonoBehaviour
{
   string[] teams = {
           
        // Premier League
        "Manchester City", "Manchester United", "Liverpool", "Chelsea", "Leicester City", "West Ham United", "Tottenham Hotspur", "Arsenal",
        "Aston Villa", "Newcastle United", "Wolverhampton", "Crystal Palace", "Southampton", "Brighton & Hove Albion", "Leeds United", 
        "Everton","Burnley", "Fulham", "Sheffield United"
   };
    public TMP_Text[] teamText;
    private void Start()
    {
        for (int i = 0; i < teamText.Length; i++)
        {
            string randomTeam = teams[Random.Range(0, teams.Length)];
            teamText[i].text = randomTeam;
        }
        //teamText.text = randomTeam;
    }
    public void RefreshButton()
    {
        string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
       
    }
}
