﻿namespace LoLStats.Data.Models
{
    using System.Collections.Generic;

    using LoLStats.Data.Common.Models;
    using LoLStats.Data.Models.Enums;

    public class Tag : BaseDeletableModel<int>
    {
        public TagType Name { get; set; }

        public ICollection<Champion> Champions { get; set; }
    }
}
