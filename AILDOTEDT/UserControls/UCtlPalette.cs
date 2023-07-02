using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AILDOTEDT.UserControls
{
    public partial class UCtlPalette : UserControl
    {
        public Color[] Colors { get; set; } = new Color[] { };

        public UCtlPalette()
        {
            InitializeComponent();
        }

        private void UCtlPalette_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void picPalette_Paint(object sender, PaintEventArgs e)
        {
            e.
        }
    }
}
