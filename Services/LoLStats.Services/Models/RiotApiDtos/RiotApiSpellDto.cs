﻿namespace LoLStats.Services.Models.RiotApiDtos
{
    using System.Collections.Generic;

    using LoLStats.Data.Models.Enums;

    public class RiotApiSpellDto
    {
        public RiotApiSpellDto()
        {
            this.PerLevelStats = new HashSet<RiotApiAbilityPerLevelDto>();
        }

        public AbilityType AbilityType { get; set; }

        public string Name { get; set; }

        public string Id { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Tooltip { get; set; }

        public byte MaxRank { get; set; }

        public ICollection<RiotApiAbilityPerLevelDto> PerLevelStats { get; set; }
    }
}
