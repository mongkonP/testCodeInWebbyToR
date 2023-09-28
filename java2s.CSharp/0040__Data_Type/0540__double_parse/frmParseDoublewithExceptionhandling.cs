using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0540__double_parse
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ParseDoublewithExceptionhandling.htm
    public partial  class frmParseDoublewithExceptionhandling:Form
    {
        public frmParseDoublewithExceptionhandling()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmParseDoublewithExceptionhandling
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmParseDoublewithExceptionhandling";
            this.Text = "frmParseDoublewithExceptionhandling";
            this.Load += new System.EventHandler(this.frmParseDoublewithExceptionhandling_Load);
            this.ResumeLayout(false);

        }

        private void frmParseDoublewithExceptionhandling_Load(object sender, EventArgs e)
        {

        }
    }
}
