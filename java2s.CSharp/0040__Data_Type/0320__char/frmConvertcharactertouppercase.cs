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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Convertcharactertouppercase.htm
    public partial  class frmConvertcharactertouppercase:Form
    {
        public frmConvertcharactertouppercase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConvertcharactertouppercase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConvertcharactertouppercase";
            this.Text = "frmConvertcharactertouppercase";
            this.Load += new System.EventHandler(this.frmConvertcharactertouppercase_Load);
            this.ResumeLayout(false);

        }

        private void frmConvertcharactertouppercase_Load(object sender, EventArgs e)
        {

        }
    }
}
