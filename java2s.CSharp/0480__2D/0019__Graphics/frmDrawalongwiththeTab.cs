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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawalongwiththeTab.htm
    public partial  class frmDrawalongwiththeTab:Form
    {
        public frmDrawalongwiththeTab()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawalongwiththeTab
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawalongwiththeTab";
            this.Text = "frmDrawalongwiththeTab";
            this.Load += new System.EventHandler(this.frmDrawalongwiththeTab_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawalongwiththeTab_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            Font f = new Font("Times New Roman", 12);
            Font bf = new Font(f, FontStyle.Bold);
            StringFormat sf = new StringFormat();
            float[] ts = { 10.0f, 70.0f, 100.0f, 90.0f };
            sf.SetTabStops(0.0f, ts);

            string s1 = "\tA\tAA\tAAA\tAAAA";
            string s2 = "\tAAAA\tAAA\tAA\tA";
            string s3 = "\tAAAAAAAA\tAAAAAAA\tAAAAAA\tAAAAA\n\tAAAA\tAAA\tAA\tAA";

            g.DrawString(s1, bf, Brushes.Black, 20, 20, sf);
            g.DrawString(s2, f, Brushes.Blue, 20, 20 + bf.Height, sf);
            g.DrawString(s3, f, Brushes.Blue, 20,
                              20 + bf.Height + f.Height, sf);

            f.Dispose();
            bf.Dispose();
        }
    }
}
