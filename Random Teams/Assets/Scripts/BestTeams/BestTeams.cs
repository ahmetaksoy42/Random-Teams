using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTeams : MonoBehaviour
{
    string[] teams = {
           
            "Bayern Munich", "Borussia Dortmund", "Inter Milan", "AC Milan", "Juventus","PSG",
            "Manchester City", "Manchester United", "Liverpool", "Chelsea","Tottenham Hotspur", "Arsenal",
            "Real Madrid", "Barcelona", "Atletico Madrid"
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
