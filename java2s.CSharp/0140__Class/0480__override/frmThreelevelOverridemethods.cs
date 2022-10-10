using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0480__override
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ThreelevelOverridemethods.htm
    public partial  class frmThreelevelOverridemethods:Form
    {
        public frmThreelevelOverridemethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreelevelOverridemethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreelevelOverridemethods";
            this.Text = "frmThreelevelOverridemethods";
            this.Load += new System.EventHandler(this.frmThreelevelOverridemethods_Load);
            this.ResumeLayout(false);

        }

        private void frmThreelevelOverridemethods_Load(object sender, EventArgs e)
        {

        }
    }
}
