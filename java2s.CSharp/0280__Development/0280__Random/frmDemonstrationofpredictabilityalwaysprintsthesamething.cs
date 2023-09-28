using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0280__Random
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Demonstrationofpredictabilityalwaysprintsthesamething.htm
    public partial  class frmDemonstrationofpredictabilityalwaysprintsthesamething:Form
    {
        public frmDemonstrationofpredictabilityalwaysprintsthesamething()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrationofpredictabilityalwaysprintsthesamething
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrationofpredictabilityalwaysprintsthesamething";
            this.Text = "frmDemonstrationofpredictabilityalwaysprintsthesamething";
            this.Load += new System.EventHandler(this.frmDemonstrationofpredictabilityalwaysprintsthesamething_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrationofpredictabilityalwaysprintsthesamething_Load(object sender, EventArgs e)
        {

        }
    }
}
