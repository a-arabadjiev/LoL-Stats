﻿namespace LoLStats.Data.Models
{
    using System.Collections.Generic;

    using LoLStats.Data.Common.Models;
    using LoLStats.Data.Models.Enums;

    public class RunePath : BaseDeletableModel<int>
    {
        public RunePath()
        {
            this.Runes = new HashSet<Rune>();
        }

        public RunePathType Name { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Rune> Runes { get; set; }
    }
}
