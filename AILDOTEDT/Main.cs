using AILDOTEDT.Models;
using System.Runtime.InteropServices;

namespace AILDOTEDT
{
    public partial class Main : Form
    {
        public Project Project { get; set; } = new Project();

        public Main()
        {
            InitializeComponent();

            //this.Cursor = new Cursor(typeof(AILDOTEDT.Main), "Resources.CursorPaint7.cur");

            /*
            Bitmap bmp = (Bitmap)Bitmap.FromFile("C:\\Users\\ishino\\source\\Git\\AILDOTEDT\\AILDOTEDT\\Resources\\Test.bmp");
            bmp.MakeTransparent(Color.Black);
            IntPtr ptr1 = bmp.GetHicon();
            */

            

        }

        private void picDotEdit_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 255), ))
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void picMain_Paint(object sender, PaintEventArgs e)
        {
            /*
            var rectangle = new Rectangle(100, 100, 500, 500);

            e.Graphics.FillRectangle(Brushes.White, rectangle);

            var step = 25;
            for (var x = rectangle.X + step; x < rectangle.Right; x += step)
            {
                e.Graphics.DrawLine(Pens.Black, new Point(x, rectangle.Top), new Point(x, rectangle.Bottom));
            }

            for (var y = rectangle.Y + step; y < rectangle.Bottom; y += step)
            {
                e.Graphics.DrawLine(Pens.Black, new Point(rectangle.X, y), new Point(rectangle.Right, y));
            }
            */

        }

        private void toolStripMenuItem_New_Click(object sender, EventArgs e)
        {
            using (var dlgNewProject = new DlgNewProject())
            {
                if (dlgNewProject.ShowDialog() == DialogResult.OK)
                {
                    Project.EditObjects.Add(new EditObject(dlgNewProject.ResultValue));
                }
            }
        }
    }
}