using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PropertyAdministration
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public string Logo { get; set; } = string.Empty;
        public DateTime CraetedAt { get; set; } = DateTime.Now;
    }
}