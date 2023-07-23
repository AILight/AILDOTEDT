using AILDOTEDT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AILDOTEDT.Models
{
    public class Palette
    {
        public string Name { get; set; }
        public Color[] Colors { get; set; }

        public Palette(MachineType machineType)
        {
            switch (machineType)
            {
                case MachineType.PC_6001MK2_Screen_3:
                    Name = "NEC PC-6001mk2 screen 3";
                    Colors = new[]
                    {
                        Color.FromArgb(0x00, 0x00, 0x00),
                        Color.FromArgb(0xAD, 0x00, 0xFF),
                        Color.FromArgb(0xFF, 0xAD, 0x00),
                        Color.FromArgb(0xFF, 0x00, 0xAD),
                        Color.FromArgb(0x00, 0xFF, 0xAD),
                        Color.FromArgb(0x00, 0xAD, 0xFF),
                        Color.FromArgb(0xAD, 0xFF, 0x00),
                        Color.FromArgb(0xAD, 0xAD, 0xAD),
                        Color.FromArgb(0x08, 0x08, 0x08),
                        Color.FromArgb(0x00, 0x00, 0xFF),
                        Color.FromArgb(0xFF, 0x00, 0x00),
                        Color.FromArgb(0xFF, 0x00, 0xFF),
                        Color.FromArgb(0x00, 0xFF, 0x00),
                        Color.FromArgb(0x00, 0xFF, 0xFF),
                        Color.FromArgb(0xFF, 0xFF, 0x00),
                        Color.FromArgb(0xFF, 0xFF, 0xFF)

                    };
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
