﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Entities
{
    public partial class OrderLine
    {
        public int LineId { get; set; }
        public int? OrderId { get; set; }
        public int? BookId { get; set; }
        public decimal? Price { get; set; }

        public virtual Book Book { get; set; }
        public virtual CustOrder Order { get; set; }
    }
}
