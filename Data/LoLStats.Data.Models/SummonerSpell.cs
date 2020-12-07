﻿namespace LoLStats.Data.Models
{
    using LoLStats.Data.Common.Models;

    public class SummonerSpell : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Tooltip { get; set; }

        public string Description { get; set; }

        public double BaseCooldown { get; set; }

        public virtual Image Image { get; set; }
    }
}
