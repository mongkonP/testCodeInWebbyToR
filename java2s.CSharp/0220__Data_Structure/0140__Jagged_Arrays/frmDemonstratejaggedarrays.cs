using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0140__Jagged_Arrays
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Demonstratejaggedarrays.htm
    public partial  class frmDemonstratejaggedarrays:Form
    {
        public frmDemonstratejaggedarrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratejaggedarrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratejaggedarrays";
            this.Text = "frmDemonstratejaggedarrays";
            this.Load += new System.EventHandler(this.frmDemonstratejaggedarrays_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratejaggedarrays_Load(object sender, EventArgs e)
        {

        }
    }
}
