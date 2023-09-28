using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1400__Double_Buffering
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DoubleBuffering.htm
    public partial  class frmDoubleBuffering:Form
    {
        public frmDoubleBuffering()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDoubleBuffering
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDoubleBuffering";
            this.Text = "frmDoubleBuffering";
            this.Load += new System.EventHandler(this.frmDoubleBuffering_Load);
            this.ResumeLayout(false);

        }

        private void frmDoubleBuffering_Load(object sender, EventArgs e)
        {

        }
    }
}
