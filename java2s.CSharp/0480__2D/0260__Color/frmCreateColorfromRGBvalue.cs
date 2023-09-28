using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0260__Color
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateColorfromRGBvalue.htm
    public partial  class frmCreateColorfromRGBvalue:Form
    {
        public frmCreateColorfromRGBvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateColorfromRGBvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateColorfromRGBvalue";
            this.Text = "frmCreateColorfromRGBvalue";
            this.Load += new System.EventHandler(this.frmCreateColorfromRGBvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateColorfromRGBvalue_Load(object sender, EventArgs e)
        {
            Color currColor = Color.FromArgb(123, 123, 123);
            this.BackColor = currColor;
            this.Text =  currColor.ToString();
        }
    }
}
