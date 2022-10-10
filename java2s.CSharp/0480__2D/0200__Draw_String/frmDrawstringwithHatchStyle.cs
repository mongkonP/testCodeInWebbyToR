using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0200__Draw_String
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawstringwithHatchStyle.htm
    public partial  class frmDrawstringwithHatchStyle:Form
    {
        public frmDrawstringwithHatchStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawstringwithHatchStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawstringwithHatchStyle";
            this.Text = "frmDrawstringwithHatchStyle";
            this.Load += new System.EventHandler(this.frmDrawstringwithHatchStyle_Load);
            this.ResumeLayout(false);

        }
        private void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int yOffSet = 10;
            Array obj = Enum.GetValues(typeof(HatchStyle));
            for (int x = 0; x < 5; x++)
            {
                HatchStyle temp = (HatchStyle)obj.GetValue(x);
                HatchBrush theBrush = new HatchBrush(temp, Color.White, Color.Black);
                g.DrawString(temp.ToString(), new Font("Times New Roman", 10),
                             Brushes.Black, 0, yOffSet);
                g.FillEllipse(theBrush, 150, yOffSet, 200, 25);
                yOffSet += 40;
            }
        }
        private void frmDrawstringwithHatchStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
