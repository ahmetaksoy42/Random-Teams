using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.Serialization;

public class MenuController : MonoBehaviour
{
    public Text takimListesiText;
    public Button EPLButton;
    public Button LaligaButton;
    public Button SeriAButton;
    public Button Ligue1Button;
    public Button BundesligaButton;
    public Button PortugalButton;
    public Button BelgiumButton;
    public Button TSLButton;
    public Button BestTeamsButton;
    public Button TopTeamsAllLeagueButton;
    public Button AllTeamsButton;
    
    

    private Dictionary<string, List<string>> leaguesAndTeams;
    private string selectedLeague;

    void Start()
    {
        // Ligler ve takımları oluştur
        leaguesAndTeams = new Dictionary<string, List<string>>();

        // Premier Lig takımları
        List<string> PremierLeagueTeams = new List<string>() {
                "Manchester City", "Manchester United", "Liverpool", "Chelsea", "Leicester City", "West Ham United", 
                "Tottenham Hotspur", "Arsenal",
                "Aston Villa", "Newcastle United", "Wolverhampton", "Crystal Palace", "Southampton", "Brighton & Hove Albion",
                "Leeds United", 
                "Everton","Burnley", "Fulham", "Sheffield United",
        };
        leaguesAndTeams.Add("Premier", PremierLeagueTeams);

        // Laliga takımları
        List<string> LaligaTeams = new List<string>() {
                "Real Madrid", "Barcelona", "Atletico Madrid", "Sevilla", "Real Sociedad", "Real Betis", 
                "Villarreal", "Celta Vigo", "Athletic Bilbao",
                "Granada", "Valencia", "Levante", "Cadiz", "Osasuna", "Getafe",
        };
        leaguesAndTeams.Add("Laliga", LaligaTeams);

        // Serie A takımları
        List<string> SerieATeams = new List<string>() {
            "Takım C1", "Takım C2", "Takım C3"
        };
        leaguesAndTeams.Add("SerieA", SerieATeams);
        // Bundesliga takımları
        List<string> BundesligaTeams = new List<string>() {
                "Bayern Munich", "Borussia Dortmund", "RB Leipzig", "VfL Wolfsburg", "Eintracht Frankfurt", 
                "Bayer Leverkusen", "Borussia Mönchengladbach",
                "SC Freiburg", "Union Berlin", "VfB Stuttgart", "TSG Hoffenheim", "Hertha Berlin", "1. FC Köln",
                "Werder Bremen", "Arminia Bielefeld",
                "FSV Mainz 05", "FC Augsburg",
        };
        leaguesAndTeams.Add("Bundesliga", BundesligaTeams);
        // Ligue1  takımları
        List<string> Ligue1Teams = new List<string>() {
                "Angers SCO", "AS Monaco", "AS Saint-Étienne", "Clermont Foot",
                "FC Lorient", "FC Nantes", "LOSC Lille",
                "OGC Nice", "Olympique de Marseille", "Olympique Lyonnais", "PSG", "RC Lens",
                "Stade de Reims", "Stade Rennais FC", "Strasbourg",
        };
        leaguesAndTeams.Add("Ligue1", Ligue1Teams);
        // Belçika takımları
        List<string> JupilerProTeams = new List<string>() {
                "Takım C1", "Takım C2", "Takım C3"
        };
        leaguesAndTeams.Add("JupilerPro", JupilerProTeams);
        // Portekiz takımları
        List<string> LigaPortugalTeams = new List<string>() {
                "Takım C1", "Takım C2", "Takım C3"
        };
        leaguesAndTeams.Add("LigaPortugal", LigaPortugalTeams);
        // TR takımları
        List<string> TSLTeams = new List<string>() {
                "Beşiktaş", "Fenerbahçe", "Galatasaray", "Trabzonspor", "Başakşehir", "Alanyaspor", "Göztepe",
                "Hatayspor", "Karagümrük",
                "Konyaspor", "Kasımpaşa", "Sivasspor",  "Kayserispor", 
                "Adana Demirspor", "Ankaragücü"
        };
        leaguesAndTeams.Add("TurkishSuperLeague", TSLTeams);
        // En iyi takımlar
        List<string> TheBestTeams = new List<string>() {
                "Takım C1", "Takım C2", "Takım C3"
        };
        leaguesAndTeams.Add("Best", TheBestTeams);
        // Her ligden en iyiler takımları
        List<string> AllLeaguesTopTierTeams = new List<string>() {
                "Takım C1", "Takım C2", "Takım C3"
        };
        leaguesAndTeams.Add("TopTeamsAllLeague", AllLeaguesTopTierTeams);
        // Bütün takımlar
        List<string> AllTeams = new List<string>() {
                "Takım C1", "Takım C2", "Takım C3"
        };
        leaguesAndTeams.Add("All", AllTeams);
        
        

        // Lig A butonuna basıldığında Lig A takımlarını göster
        EPLButton.onClick.AddListener(ShowEPL);
        LaligaButton.onClick.AddListener(ShowLaLiga);
        SeriAButton.onClick.AddListener(ShowSerieA);
        Ligue1Button.onClick.AddListener(ShowLigue1);
        BundesligaButton.onClick.AddListener(ShowBundesliga);
        BelgiumButton.onClick.AddListener(ShowJupilerPro);
        PortugalButton.onClick.AddListener(ShowLigaPortugal);
        TSLButton.onClick.AddListener(ShowTSL);
        BestTeamsButton.onClick.AddListener(ShowBestTeams);
        TopTeamsAllLeagueButton.onClick.AddListener(ShowTopTeamsAllLeague);
        AllTeamsButton.onClick.AddListener(ShowAllTeams);
       
    }

    void ShowEPL()
    {
        selectedLeague = "Premier";
        ShowTakimlar();
    }
    void ShowLaLiga()
    {
        selectedLeague = "Laliga";
        ShowTakimlar();
    }
    void ShowSerieA()
    {
        selectedLeague = "SerieA";
        ShowTakimlar();
    }
    void ShowLigue1()
    {
        selectedLeague = "Ligue1";
        ShowTakimlar();
    }
    void ShowBundesliga()
    {
        selectedLeague = "Bundesliga";
        ShowTakimlar();
    }
    void ShowJupilerPro()
    {
        selectedLeague = "JupilerPro";
        ShowTakimlar();
    }
    void ShowLigaPortugal()
    {
        selectedLeague = "LigaPortugal";
        ShowTakimlar();
    }
    void ShowTSL()
    {
        selectedLeague = "TurkishSuperLeague";
        ShowTakimlar();
        
    }
    void ShowBestTeams()
    {
        selectedLeague = "Best";
        ShowTakimlar();
    }
    void ShowTopTeamsAllLeague()
    {
        selectedLeague = "TopTeamsAllLeague";
        ShowTakimlar();
    }
    void ShowAllTeams()
    {
        selectedLeague = "All";
        ShowTakimlar();
    }

    void ShowTakimlar()
    {
        if (leaguesAndTeams.ContainsKey(selectedLeague))
        {
            List<string> seciliLigTakimlari = leaguesAndTeams[selectedLeague];
            string takimListesi = string.Join("\n", seciliLigTakimlari);
            takimListesiText.text = takimListesi;
        }
        else
        {
            takimListesiText.text = "Seçili lig bulunamadı!";
        }
    }
}
