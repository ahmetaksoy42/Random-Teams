using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Teams : MonoBehaviour
{
    string[] teams = {
            
        // Türkiye Süper Lig
        "Beşiktaş", "Fenerbahçe", "Galatasaray", "Trabzonspor", "Başakşehir", "Alanyaspor", "Göztepe", "Hatayspor", "Karagümrük",
        "Konyaspor", "Kasımpaşa", "Sivasspor", "Rizespor", "Gazişehir Gaziantep", "Kayserispor", "Adana Demirspor", "Altay",
        // Türkiye 1. Lig
        "Bursaspor", "Eskişehirspor", "Samsunspor",
        // Bundesliga
        "Bayern Munich", "Borussia Dortmund", "RB Leipzig", "VfL Wolfsburg", "Eintracht Frankfurt", "Bayer Leverkusen", "Borussia Mönchengladbach",
        "SC Freiburg", "Union Berlin", "VfB Stuttgart", "TSG Hoffenheim", "Hertha Berlin", "1. FC Köln", "Werder Bremen", "Arminia Bielefeld",
        "FSV Mainz 05", "FC Augsburg",
        // 2. Bundesliga
        "Hamburg", "Schalke 04",
        // Serie A
        "Inter Milan", "AC Milan", "Juventus", "Atalanta", "Napoli", "Lazio", "Roma", "Sassuolo", "Sampdoria", "Udinese", "Fiorentina",
        "Genoa", "Cagliari", "Torino", "Bologna", "Spezia", "Verona", "Parma",
        // Serie B
        "Venezia", "Empoli", "Salernitana", "Lecce" ,
        // La Liga
        "Real Madrid", "Barcelona", "Atletico Madrid", "Sevilla", "Real Sociedad", "Real Betis", "Villarreal", "Celta Vigo", "Athletic Bilbao",
        "Granada", "Valencia", "Levante", "Cadiz", "Osasuna", "Getafe",
        // Ligue 1
        "Angers SCO", "AS Monaco", "AS Saint-Étienne", "Clermont Foot",
        "FC Lorient", "FC Nantes", "LOSC Lille",
        "OGC Nice", "Olympique de Marseille", "Olympique Lyonnais", "PSG", "RC Lens",
        "Stade de Reims", "Stade Rennais FC", "Strasbourg",
        // Premier League
        "Manchester City", "Manchester United", "Liverpool", "Chelsea", "Leicester City", "West Ham United", "Tottenham Hotspur", "Arsenal",
        "Aston Villa", "Newcastle United", "Wolverhampton", "Crystal Palace", "Southampton", "Brighton & Hove Albion", "Leeds United", 
        "Everton","Burnley", "Fulham", "Sheffield United",
        //Championship
        "AFC Bournemouth", "Barnsley", "Birmingham City", 
        "Bristol City", "Cardiff City", "Coventry City", "Derby County", "Fulham", 
        "Hull City", "Nottingham Forest", "West Bromwich Albion",
        "Queens Park Rangers", "Sheffield United", "Stoke City", "Swansea City",
        // Keyif
        "Premier L. 5.sıra(Oyundaki)","STSL 8.sıra(Oyundaki)","Laliga 10.sıra(Oyundaki)", "Kafana göre takıl", 
        "Bundesliga Random","Preimer Random", "STSL Random", "LaLiga Random", "Seria A Random"

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
