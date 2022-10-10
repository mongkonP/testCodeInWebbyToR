using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0900__yield
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Usemultipleyieldstatements.htm
    public partial  class frmUsemultipleyieldstatements:Form
    {
        public frmUsemultipleyieldstatements()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsemultipleyieldstatements
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsemultipleyieldstatements";
            this.Text = "frmUsemultipleyieldstatements";
            this.Load += new System.EventHandler(this.frmUsemultipleyieldstatements_Load);
            this.ResumeLayout(false);

        }

        private void frmUsemultipleyieldstatements_Load(object sender, EventArgs e)
        {

        }
    }
}
