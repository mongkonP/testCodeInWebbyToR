using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/DetectingProcessCompletion.htm
    public partial  class frmDetectingProcessCompletion:Form
    {
        public frmDetectingProcessCompletion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDetectingProcessCompletion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDetectingProcessCompletion";
            this.Text = "frmDetectingProcessCompletion";
            this.Load += new System.EventHandler(this.frmDetectingProcessCompletion_Load);
            this.ResumeLayout(false);

        }

        private void frmDetectingProcessCompletion_Load(object sender, EventArgs e)
        {

        }
    }
}
