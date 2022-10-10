using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/PrimaryThreadstatistcs.htm
    public partial  class frmPrimaryThreadstatistcs:Form
    {
        public frmPrimaryThreadstatistcs()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrimaryThreadstatistcs
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrimaryThreadstatistcs";
            this.Text = "frmPrimaryThreadstatistcs";
            this.Load += new System.EventHandler(this.frmPrimaryThreadstatistcs_Load);
            this.ResumeLayout(false);

        }

        private void frmPrimaryThreadstatistcs_Load(object sender, EventArgs e)
        {

        }
    }
}
