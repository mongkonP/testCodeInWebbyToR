using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ClassFundamentals.htm
    public partial  class frmClassFundamentals:Form
    {
        public frmClassFundamentals()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClassFundamentals
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClassFundamentals";
            this.Text = "frmClassFundamentals";
            this.Load += new System.EventHandler(this.frmClassFundamentals_Load);
            this.ResumeLayout(false);

        }

        private void frmClassFundamentals_Load(object sender, EventArgs e)
        {

        }
    }
}
