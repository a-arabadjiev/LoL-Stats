﻿namespace LoLStats.Data.Models
{
    using LoLStats.Data.Common.Models;
    using LoLStats.Data.Models.Enums;

    public class AbilityPerLevel : BaseDeletableModel<int>
    {
        public string BaseChampionAbilityId { get; set; }

        public BaseAbility Ability { get; set; }

        public byte Level { get; set; }

        public double Cooldown { get; set; }

        public double Cost { get; set; }

        public bool CostsPerSecond { get; set; }

        public double Range { get; set; }
    }
}
