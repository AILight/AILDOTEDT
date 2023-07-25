using AILDOTEDT.Models;
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
        public EditStatus ResultValue { get; private set; } = new EditStatus();

        public DlgNewProject()
        {
            InitializeComponent();

            txtName.Text = "キャラクター";
            nudScreenWidth.Value = 800;
            nudScreenHeight.Value = 600;
            nudCharacterWidth.Value = 16;
            nudCharacterHeight.Value = 8;
            nudColorCount.Value = 16;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ResultValue = new EditStatus()
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
