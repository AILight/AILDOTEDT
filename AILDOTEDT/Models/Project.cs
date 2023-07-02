using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class Project
    {
        public string Name { get; set; } = "";
        public List<EditObject> EditObjects { get; set; } = new List<EditObject>();
    }
}
