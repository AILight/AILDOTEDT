using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class EditContent
    {
        public EditStatus Status { get; }
        public List<Layer> LayerList { get; set; } = new List<Layer>();

        public EditContent(EditStatus status)
        {
            Status = status;
        }
    }
}
