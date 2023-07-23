using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AILDOTEDT
{
    public partial class DlgNewProject : Form
    {
        public class ResultValueModel
        {
            public string Name { get; set; } = string.Empty;
            public int ScreenWidth { get; set; }
            public int ScreenHeight { get; set; }
            public int CharacterWidth { get; set; }
            public int CharacterHeight { get; set; }
            public int ColorCount { get; set; }
        }

        public ResultValueModel? ResultValue { get; private set; }

        public DlgNewProject()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ResultValue = new ResultValueModel()
            {
                Name = txtName.Text,
                ScreenWidth = (int)nudScreenWidth.Value,
                ScreenHeight = (int)nudScreenHeight.Value,
                CharacterWidth = (int)nudCharacterWidth.Value,
                CharacterHeight = (int)nudCharacterHeight.Value,
                ColorCount = (int)nudColorCount.Value
            };

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DlgNewProject_Load(object sender, EventArgs e)
        {

        }
    }
}
