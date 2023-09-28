using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0200__Draw_String
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawstringalongacircle.htm
    public partial  class frmDrawstringalongacircle:Form
    {
        private System.ComponentModel.Container components = null;
        public frmDrawstringalongacircle()
        {
            InitializeComponent();
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawstringalongacircle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawstringalongacircle";
            this.Text = "frmDrawstringalongacircle";
            this.Load += new System.EventHandler(this.frmDrawstringalongacircle_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SetScale(g);
            DrawFace(g);
            base.OnPaint(e);
        }
        private void SetScale(Graphics g)
        {
            g.TranslateTransform(Width / 2, Height / 2);

            float inches = Math.Min(Width / g.DpiX, Height / g.DpiX);

            g.ScaleTransform(inches * g.DpiX / 2000, inches * g.DpiY / 2000);
        }

        private void DrawFace(Graphics g)
        {
            Brush brush = new SolidBrush(ForeColor);
            Font font = new Font("Arial", 40);

            float x, y;

            const int numHours = 12;
            const int deg = 360 / numHours;
            const int FaceRadius = 450;

            for (int i = 1; i <= numHours; i++)
            {
                x = GetCos(i * deg + 90) * FaceRadius;
                y = GetSin(i * deg + 90) * FaceRadius;

                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString(i.ToString(), font, brush, -x, -y, format);

            }
            brush.Dispose();
            font.Dispose();
        }

        private static float GetSin(float degAngle)
        {
            return (float)Math.Sin(Math.PI * degAngle / 180f);
        }

        private static float GetCos(float degAngle)
        {
            return (float)Math.Cos(Math.PI * degAngle / 180f);
        }
        private void frmDrawstringalongacircle_Load(object sender, EventArgs e)
        {

        }
    }
}
