using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class EditObject
    {
        public EditStatus? ResultValue { get; }
        public List<Layer> LayerList { get; set; } = new List<Layer>();

        public EditObject(EditStatus? resultValue)
        {
            ResultValue = resultValue;
        }
    }
}
