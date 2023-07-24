using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class EditStatus
    {
        public string Name { get; set; } = string.Empty;
        public Palette Palette { get; set; } = new Palette(Enums.MachineType.PC_6001MK2_Screen_3);
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int CharacterWidth { get; set; }
        public int CharacterHeight { get; set; }
        public int ColorCount { get; set; }
    }
}
