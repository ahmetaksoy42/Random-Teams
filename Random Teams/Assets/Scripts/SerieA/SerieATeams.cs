using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SerieATeams : MonoBehaviour
{
    string[] teams = {
           
            "Inter Milan", "AC Milan", "Juventus", "Atalanta", "Napoli", "Lazio", "Roma", "Sassuolo", "Sampdoria", "Udinese", "Fiorentina",
            "Genoa", "Cagliari", "Torino", "Bologna", "Spezia", "Verona", "Parma"
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
