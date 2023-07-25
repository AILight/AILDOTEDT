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
        public List<EditContent> EditContents { get; set; } = new List<EditContent>();
        public EditContent? SelectedEditContent = default(EditContent);
    }
}
