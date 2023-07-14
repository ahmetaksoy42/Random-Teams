using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TSLTeams : MonoBehaviour
{
    private string[] teams =
    {   
            // Türkiye Süper Lig
      "Beşiktaş", "Fenerbahçe", "Galatasaray", "Trabzonspor", "Başakşehir", "Alanyaspor", "Göztepe", "Hatayspor", "Karagümrük",
      "Konyaspor", "Kasımpaşa", "Sivasspor", "Kayserispor", "Adana Demirspor", "Ankaragücü","Kasımpaşa"
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
