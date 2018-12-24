using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helfo.App.Models
{
    public class PluginMeta
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Version { get; set; }
        public DateTime InstalledOn { get; set; }
        public int Priority { get; set; }
        
    }
}
