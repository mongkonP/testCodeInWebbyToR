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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TextBoxModifiedandTextChanged.htm
    public partial  class frmTextBoxModifiedandTextChanged:Form
    {
        public frmTextBoxModifiedandTextChanged()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxModifiedandTextChanged
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxModifiedandTextChanged";
            this.Text = "frmTextBoxModifiedandTextChanged";
            this.Load += new System.EventHandler(this.frmTextBoxModifiedandTextChanged_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxModifiedandTextChanged_Load(object sender, EventArgs e)
        {

        }
    }
}
