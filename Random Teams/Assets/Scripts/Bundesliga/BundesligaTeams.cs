using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BundesligaTeams : MonoBehaviour
{
    string[] teams = {
           
            "Bayern Munich", "Borussia Dortmund", "RB Leipzig", "VfL Wolfsburg", "Eintracht Frankfurt", "Bayer Leverkusen", "Borussia Mönchengladbach",
            "SC Freiburg", "Union Berlin", "VfB Stuttgart", "TSG Hoffenheim", "Hertha Berlin", "1. FC Köln", "Werder Bremen", "Arminia Bielefeld",
            "FSV Mainz 05", "FC Augsburg"
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
