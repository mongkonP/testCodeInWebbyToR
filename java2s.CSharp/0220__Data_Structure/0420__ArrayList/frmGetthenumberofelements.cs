using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Getthenumberofelements.htm
    public partial  class frmGetthenumberofelements:Form
    {
        public frmGetthenumberofelements()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthenumberofelements
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthenumberofelements";
            this.Text = "frmGetthenumberofelements";
            this.Load += new System.EventHandler(this.frmGetthenumberofelements_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthenumberofelements_Load(object sender, EventArgs e)
        {

        }
    }
}
