﻿namespace LoLStats.Services.Models.RiotApiDtos
{
    using System.Collections.Generic;

    using LoLStats.Data.Models.Enums;

    public class RiotApiChampionDto
    {
        public RiotApiChampionDto()
        {
            this.AllyTips = new HashSet<RiotApiChampionTipDto>();
            this.EnemyTips = new HashSet<RiotApiChampionTipDto>();
            this.Tags = new HashSet<RiotApiChampionTagDto>();
            this.Spells = new HashSet<RiotApiSpellDto>();
        }

        public string Name { get; set; }

        public bool IsFree { get; set; }

        public string Id { get; set; }

        public string Title { get; set; }

        public ICollection<RiotApiChampionTipDto> AllyTips { get; set; }

        public ICollection<RiotApiChampionTipDto> EnemyTips { get; set; }

        public string ImageUrl { get; set; }

        public RiotApiChampionInfoDto Info { get; set; }

        public string Lore { get; set; }

        public ResourceType Partype { get; set; }

        public RiotApiChampionPassiveDto Passive { get; set; }

        public RiotApiChampionStatsDto Stats { get; set; }

        public ICollection<RiotApiChampionTagDto> Tags { get; set; }

        public ICollection<RiotApiSpellDto> Spells { get; set; }
    }
}
