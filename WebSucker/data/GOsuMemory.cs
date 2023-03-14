using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GOsumemory.data;

namespace GOsumemory.data
{
    public partial class RootGameplay
    {
        [JsonProperty("gameMode")]
        public long GameMode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("accuracy")]
        public long Accuracy { get; set; }

        [JsonProperty("combo")]
        public Combo Combo { get; set; }

        [JsonProperty("hp")]
        public Hp Hp { get; set; }

        [JsonProperty("hits")]
        public Hits Hits { get; set; }

        [JsonProperty("pp")]
        public GameplayPp Pp { get; set; }

        [JsonProperty("keyOverlay")]
        public KeyOverlay KeyOverlay { get; set; }

        [JsonProperty("leaderboard")]
        public Leaderboard Leaderboard { get; set; }
    }

    public partial class Combo
    {
        [JsonProperty("current")]
        public long Current { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }
    }

    public partial class Hits
    {
        [JsonProperty("0")]
        public long The0 { get; set; }

        [JsonProperty("50")]
        public long The50 { get; set; }

        [JsonProperty("100")]
        public long The100 { get; set; }

        [JsonProperty("300")]
        public long The300 { get; set; }

        [JsonProperty("geki")]
        public long Geki { get; set; }

        [JsonProperty("katu")]
        public long Katu { get; set; }

        [JsonProperty("sliderBreaks")]
        public long SliderBreaks { get; set; }

        [JsonProperty("grade")]
        public Grade Grade { get; set; }

        [JsonProperty("unstableRate")]
        public long UnstableRate { get; set; }

        [JsonProperty("hitErrorArray")]
        public object HitErrorArray { get; set; }
    }

    public partial class Grade
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("maxThisPlay")]
        public string MaxThisPlay { get; set; }
    }

    public partial class Hp
    {
        [JsonProperty("normal")]
        public long Normal { get; set; }

        [JsonProperty("smooth")]
        public long Smooth { get; set; }
    }

    public partial class KeyOverlay
    {
        [JsonProperty("k1")]
        public K1 K1 { get; set; }

        [JsonProperty("k2")]
        public K1 K2 { get; set; }

        [JsonProperty("m1")]
        public K1 M1 { get; set; }

        [JsonProperty("m2")]
        public K1 M2 { get; set; }
    }

    public partial class K1
    {
        [JsonProperty("isPressed")]
        public bool IsPressed { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class Leaderboard
    {
        [JsonProperty("hasLeaderboard")]
        public bool HasLeaderboard { get; set; }

        [JsonProperty("isVisible")]
        public bool IsVisible { get; set; }

        [JsonProperty("ourplayer")]
        public Ourplayer Ourplayer { get; set; }

        [JsonProperty("slots")]
        public object Slots { get; set; }
    }

    public partial class Ourplayer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("combo")]
        public long Combo { get; set; }

        [JsonProperty("maxCombo")]
        public long MaxCombo { get; set; }

        [JsonProperty("mods")]
        public string Mods { get; set; }

        [JsonProperty("h300")]
        public long H300 { get; set; }

        [JsonProperty("h100")]
        public long H100 { get; set; }

        [JsonProperty("h50")]
        public long H50 { get; set; }

        [JsonProperty("h0")]
        public long H0 { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("isPassing")]
        public long IsPassing { get; set; }
    }

    public partial class GameplayPp
    {
        [JsonProperty("current")]
        public long Current { get; set; }

        [JsonProperty("fc")]
        public long Fc { get; set; }

        [JsonProperty("maxThisPlay")]
        public long MaxThisPlay { get; set; }
    }

    public partial class Menu
    {
        [JsonProperty("mainMenu")]
        public MainMenu MainMenu { get; set; }

        [JsonProperty("state")]
        public long State { get; set; }

        [JsonProperty("gameMode")]
        public long GameMode { get; set; }

        [JsonProperty("isChatEnabled")]
        public long IsChatEnabled { get; set; }

        [JsonProperty("bm")]
        public Bm Bm { get; set; }

        [JsonProperty("mods")]
        public Mods Mods { get; set; }

        [JsonProperty("pp")]
        public MenuPp Pp { get; set; }
    }

    public partial class Bm
    {
        [JsonProperty("time")]
        public Time Time { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("set")]
        public long Set { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("rankedStatus")]
        public long RankedStatus { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("path")]
        public Path Path { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artistOriginal")]
        public string ArtistOriginal { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("titleOriginal")]
        public string TitleOriginal { get; set; }

        [JsonProperty("mapper")]
        public string Mapper { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
    }

    public partial class Path
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("bg")]
        public string Bg { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("AR")]
        public double Ar { get; set; }

        [JsonProperty("CS")]
        public double Cs { get; set; }

        [JsonProperty("OD")]
        public long Od { get; set; }

        [JsonProperty("HP")]
        public long Hp { get; set; }

        [JsonProperty("SR")]
        public long Sr { get; set; }

        [JsonProperty("BPM")]
        public Bpm Bpm { get; set; }

        [JsonProperty("maxCombo")]
        public long MaxCombo { get; set; }

        [JsonProperty("fullSR")]
        public double FullSr { get; set; }

        [JsonProperty("memoryAR")]
        public double MemoryAr { get; set; }

        [JsonProperty("memoryCS")]
        public double MemoryCs { get; set; }

        [JsonProperty("memoryOD")]
        public long MemoryOd { get; set; }

        [JsonProperty("memoryHP")]
        public long MemoryHp { get; set; }
    }

    public partial class Bpm
    {
        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }
    }

    public partial class Time
    {
        [JsonProperty("firstObj")]
        public long FirstObj { get; set; }

        [JsonProperty("current")]
        public long Current { get; set; }

        [JsonProperty("full")]
        public long Full { get; set; }

        [JsonProperty("mp3")]
        public long Mp3 { get; set; }
    }

    public partial class MainMenu
    {
        [JsonProperty("bassDensity")]
        public long BassDensity { get; set; }
    }

    public partial class Mods
    {
        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("str")]
        public string Str { get; set; }
    }

    public partial class MenuPp
    {
        [JsonProperty("95")]
        public long The95 { get; set; }

        [JsonProperty("96")]
        public long The96 { get; set; }

        [JsonProperty("97")]
        public long The97 { get; set; }

        [JsonProperty("98")]
        public long The98 { get; set; }

        [JsonProperty("99")]
        public long The99 { get; set; }

        [JsonProperty("100")]
        public long The100 { get; set; }

        [JsonProperty("strains")]
        public double[] Strains { get; set; }
    }

    public partial class ResultsScreen
    {
        [JsonProperty("0")]
        public long The0 { get; set; }

        [JsonProperty("50")]
        public long The50 { get; set; }

        [JsonProperty("100")]
        public long The100 { get; set; }

        [JsonProperty("300")]
        public long The300 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("maxCombo")]
        public long MaxCombo { get; set; }

        [JsonProperty("mods")]
        public Mods Mods { get; set; }

        [JsonProperty("geki")]
        public long Geki { get; set; }

        [JsonProperty("katu")]
        public long Katu { get; set; }
    }

    public partial class Settings
    {
        [JsonProperty("showInterface")]
        public bool ShowInterface { get; set; }

        [JsonProperty("folders")]
        public Folders Folders { get; set; }
    }

    public partial class Folders
    {
        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("skin")]
        public string Skin { get; set; }

        [JsonProperty("songs")]
        public string Songs { get; set; }
    }

    public partial class Tourney
    {
        [JsonProperty("manager")]
        public Manager Manager { get; set; }

        [JsonProperty("ipcClients")]
        public object IpcClients { get; set; }
    }

    public partial class Manager
    {
        [JsonProperty("ipcState")]
        public long IpcState { get; set; }

        [JsonProperty("bestOF")]
        public long BestOf { get; set; }

        [JsonProperty("teamName")]
        public TeamName TeamName { get; set; }

        [JsonProperty("stars")]
        public Stars Stars { get; set; }

        [JsonProperty("bools")]
        public Bools Bools { get; set; }

        [JsonProperty("chat")]
        public object Chat { get; set; }

        [JsonProperty("gameplay")]
        public ManagerGameplay Gameplay { get; set; }
    }

    public partial class Bools
    {
        [JsonProperty("scoreVisible")]
        public bool ScoreVisible { get; set; }

        [JsonProperty("starsVisible")]
        public bool StarsVisible { get; set; }
    }

    public partial class ManagerGameplay
    {
        [JsonProperty("score")]
        public Stars Score { get; set; }
    }

    public partial class Stars
    {
        [JsonProperty("left")]
        public long Left { get; set; }

        [JsonProperty("right")]
        public long Right { get; set; }
    }

    public partial class TeamName
    {
        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("right")]
        public string Right { get; set; }
    }
}


namespace GOsumemory
{

    public partial class Root
    {
        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("menu")]
        public Menu Menu { get; set; }

        [JsonProperty("gameplay")]
        public RootGameplay Gameplay { get; set; }

        [JsonProperty("resultsScreen")]
        public ResultsScreen ResultsScreen { get; set; }

        [JsonProperty("tourney")]
        public Tourney Tourney { get; set; }
    }
}