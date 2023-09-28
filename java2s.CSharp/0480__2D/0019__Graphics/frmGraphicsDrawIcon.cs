using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsDrawIcon.htm
    public partial  class frmGraphicsDrawIcon:Form
    {
        public frmGraphicsDrawIcon()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsDrawIcon
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsDrawIcon";
            this.Text = "frmGraphicsDrawIcon";
            this.Load += new System.EventHandler(this.frmGraphicsDrawIcon_Load);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.ResumeLayout(false);

        }

        private void frmGraphicsDrawIcon_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender,
        System.Windows.Forms.PaintEventArgs p)
        {
            Graphics g = p.Graphics;
        }
        private void createManually()
        {
            Graphics g;
            g = this.CreateGraphics();
        }
        private void createFromFile()
        {
            Graphics g;
            Bitmap b;
            b = new Bitmap(Application.StartupPath + @"\Files\Image\promotion_marketing.png");
            g = Graphics.FromImage(b);
        }
        private void drawLine()
        {

            Graphics g;
            g = this.CreateGraphics();

            Icon i = new Icon(Application.StartupPath + @"\Files\Image\business_laptop.ico");
            g.DrawIcon(i, 150, 15);
        }
    }
}
