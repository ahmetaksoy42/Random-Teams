using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void LoadMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    public void LoadPremierLeagueScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PremierLeague");
    }
    public void LoadSerieAScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SerieA");
    }
    public void LoadLaLigaScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LaLiga");
    }
    public void LoadBundesligaScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Bundesliga");
    }
    public void LoadLigue1Scene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Ligue1");
    }
    public void LoadTSLScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TSL");
    }
    public void LoadBestTeamsScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("BestTeams");
    }
    
   
}
