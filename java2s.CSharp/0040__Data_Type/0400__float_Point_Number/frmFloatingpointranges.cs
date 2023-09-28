using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0400__float_Point_Number
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Floatingpointranges.htm
    public partial  class frmFloatingpointranges:Form
    {
        public frmFloatingpointranges()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFloatingpointranges
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFloatingpointranges";
            this.Text = "frmFloatingpointranges";
            this.Load += new System.EventHandler(this.frmFloatingpointranges_Load);
            this.ResumeLayout(false);

        }

        private void frmFloatingpointranges_Load(object sender, EventArgs e)
        {

        }
    }
}
