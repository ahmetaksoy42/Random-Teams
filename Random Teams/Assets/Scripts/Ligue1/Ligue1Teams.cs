using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ligue1Teams : MonoBehaviour
{
    string[] teams = {
           
            "Angers SCO", "AS Monaco", "AS Saint-Étienne", "Clermont Foot",
            "FC Lorient", "FC Nantes", "LOSC Lille",
            "OGC Nice", "Olympique de Marseille", "Olympique Lyonnais", "PSG", "RC Lens",
            "Stade de Reims", "Stade Rennais FC", "Strasbourg"
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
