﻿namespace LoLStats.Data.Models
{
    using LoLStats.Data.Common.Models;

    public class Passive : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual Champion Champion { get; set; }

        public int ChampionId { get; set; }
    }
}
