using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Listrangeoperation.htm
    public partial  class frmListrangeoperation:Form
    {
        public frmListrangeoperation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListrangeoperation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListrangeoperation";
            this.Text = "frmListrangeoperation";
            this.Load += new System.EventHandler(this.frmListrangeoperation_Load);
            this.ResumeLayout(false);

        }

        private void frmListrangeoperation_Load(object sender, EventArgs e)
        {

        }
    }
}
