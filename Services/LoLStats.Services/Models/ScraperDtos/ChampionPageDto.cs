﻿namespace LoLStats.Services.Models.ScraperDtos
{
    using System.Collections.Generic;

    using LoLStats.Data.Models.Enums;

    public class ChampionPageDto
    {
        public ChampionPageDto()
        {
            this.SummonerSpells = new List<string>();
            this.PrimaryRunes = new List<string>();
            this.SecondaryRunes = new List<string>();
            this.StatRunes = new List<StatRuneType>();
            this.SkillsPriority = new List<string>();
            this.CounterChampions = new List<string>();
            this.StartingItems = new List<string>();
            this.ItemsWinRateKvp = new Dictionary<string, int>();
        }

        public string Key { get; set; }

        public string Patch { get; set; }

        public RoleType Role { get; set; }

        public string ChampionTier { get; set; }

        public double ChampionWinRate { get; set; }

        public double ChampionPickRate { get; set; }

        public double ChampionBanRate { get; set; }

        public int ChampionTotalMatches { get; set; }

        public ICollection<string> SummonerSpells { get; set; }

        public double SummonerSpellsWinRate { get; set; }

        public int SummonerSpellsTotalMatches { get; set; }

        public RuneTreeType MainRuneTree { get; set; }

        public ICollection<string> PrimaryRunes { get; set; }

        public RuneTreeType SecondaryRuneTree { get; set; }

        public ICollection<string> SecondaryRunes { get; set; }

        public ICollection<StatRuneType> StatRunes { get; set; }

        public double RunesWinRate { get; set; }

        public int RunesMatchesCount { get; set; }

        public ICollection<string> SkillsPriority { get; set; }

        public double SkillsWinRate { get; set; }

        public int SkillsMatchesCount { get; set; }

        public ICollection<string> CounterChampions { get; set; }

        public ICollection<string> StartingItems { get; set; }

        public int StartingItemsWinRate { get; set; }

        public int StartingItemsPickRate { get; set; }

        public IDictionary<string, int> ItemsWinRateKvp { get; set; }
    }
}
