using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Entities
{
    public partial class CustomerAddress
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int? StatusId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
