using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0320__private
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UsingMethodstochangeprivatefields.htm
    public partial  class frmUsingMethodstochangeprivatefields:Form
    {
        public frmUsingMethodstochangeprivatefields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingMethodstochangeprivatefields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingMethodstochangeprivatefields";
            this.Text = "frmUsingMethodstochangeprivatefields";
            this.Load += new System.EventHandler(this.frmUsingMethodstochangeprivatefields_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingMethodstochangeprivatefields_Load(object sender, EventArgs e)
        {

        }
    }
}
