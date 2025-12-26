using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PropertyAdministration
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Logo { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}