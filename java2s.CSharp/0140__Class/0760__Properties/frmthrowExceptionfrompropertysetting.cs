using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/throwExceptionfrompropertysetting.htm
    public partial  class frmthrowExceptionfrompropertysetting:Form
    {
        public frmthrowExceptionfrompropertysetting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmthrowExceptionfrompropertysetting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmthrowExceptionfrompropertysetting";
            this.Text = "frmthrowExceptionfrompropertysetting";
            this.Load += new System.EventHandler(this.frmthrowExceptionfrompropertysetting_Load);
            this.ResumeLayout(false);

        }

        private void frmthrowExceptionfrompropertysetting_Load(object sender, EventArgs e)
        {

        }
    }
}
