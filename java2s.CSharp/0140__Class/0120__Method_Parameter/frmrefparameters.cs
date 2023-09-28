using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/refparameters.htm
    public partial  class frmrefparameters:Form
    {
        public frmrefparameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmrefparameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmrefparameters";
            this.Text = "frmrefparameters";
            this.Load += new System.EventHandler(this.frmrefparameters_Load);
            this.ResumeLayout(false);

        }

        private void frmrefparameters_Load(object sender, EventArgs e)
        {

        }
    }
}
