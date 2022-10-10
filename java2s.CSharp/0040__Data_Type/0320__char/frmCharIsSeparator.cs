using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0320__char
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/CharIsSeparator.htm
    public partial  class frmCharIsSeparator:Form
    {
        public frmCharIsSeparator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCharIsSeparator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCharIsSeparator";
            this.Text = "frmCharIsSeparator";
            this.Load += new System.EventHandler(this.frmCharIsSeparator_Load);
            this.ResumeLayout(false);

        }

        private void frmCharIsSeparator_Load(object sender, EventArgs e)
        {

        }
    }
}
