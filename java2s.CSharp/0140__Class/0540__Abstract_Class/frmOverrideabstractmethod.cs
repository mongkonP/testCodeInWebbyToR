using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0540__Abstract_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Overrideabstractmethod.htm
    public partial  class frmOverrideabstractmethod:Form
    {
        public frmOverrideabstractmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverrideabstractmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverrideabstractmethod";
            this.Text = "frmOverrideabstractmethod";
            this.Load += new System.EventHandler(this.frmOverrideabstractmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmOverrideabstractmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
