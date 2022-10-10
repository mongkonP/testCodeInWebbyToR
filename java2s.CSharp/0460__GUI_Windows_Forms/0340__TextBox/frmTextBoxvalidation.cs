using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0340__TextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TextBoxvalidation.htm
    public partial  class frmTextBoxvalidation:Form
    {
        public frmTextBoxvalidation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxvalidation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxvalidation";
            this.Text = "frmTextBoxvalidation";
            this.Load += new System.EventHandler(this.frmTextBoxvalidation_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxvalidation_Load(object sender, EventArgs e)
        {

        }
    }
}
