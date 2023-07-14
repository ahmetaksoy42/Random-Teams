using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LaLigaTeams : MonoBehaviour
{
    private string[] teams =
    {   
            "Real Madrid", "Barcelona", "Atletico Madrid", "Sevilla", "Real Sociedad", "Real Betis", 
            "Villarreal", "Celta Vigo", "Athletic Bilbao",
            "Granada", "Valencia", "Levante", "Cadiz", "Osasuna", "Getafe"
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
