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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TextBoxselection.htm
    public partial  class frmTextBoxselection:Form
    {
        public frmTextBoxselection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxselection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxselection";
            this.Text = "frmTextBoxselection";
            this.Load += new System.EventHandler(this.frmTextBoxselection_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxselection_Load(object sender, EventArgs e)
        {

        }
    }
}
