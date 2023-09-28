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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Virtualandoverridememberfunction.htm
    public partial  class frmVirtualandoverridememberfunction:Form
    {
        public frmVirtualandoverridememberfunction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVirtualandoverridememberfunction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVirtualandoverridememberfunction";
            this.Text = "frmVirtualandoverridememberfunction";
            this.Load += new System.EventHandler(this.frmVirtualandoverridememberfunction_Load);
            this.ResumeLayout(false);

        }

        private void frmVirtualandoverridememberfunction_Load(object sender, EventArgs e)
        {

        }
    }
}
