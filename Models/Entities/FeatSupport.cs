using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Entities
{
    public class FeatSupport
    {
        public int ID { get; set; }
        public int IdSection { get; set; }
        public string SupoortType { get; set; }
        public string SupportClass { get; set; }
        public string SupportId { get; set; }
        public string SupportName { get; set; }
        public int Grams { get; set; }
    }
}
