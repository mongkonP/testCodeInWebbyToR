using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Demonstrateavirtualmethod.htm
    public partial  class frmDemonstrateavirtualmethod:Form
    {
        public frmDemonstrateavirtualmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateavirtualmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateavirtualmethod";
            this.Text = "frmDemonstrateavirtualmethod";
            this.Load += new System.EventHandler(this.frmDemonstrateavirtualmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateavirtualmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
