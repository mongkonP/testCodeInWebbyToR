using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0080__int_array
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/intarrays.htm
    public partial  class frmintarrays:Form
    {
        public frmintarrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmintarrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmintarrays";
            this.Text = "frmintarrays";
            this.Load += new System.EventHandler(this.frmintarrays_Load);
            this.ResumeLayout(false);

        }

        private void frmintarrays_Load(object sender, EventArgs e)
        {

        }
    }
}
