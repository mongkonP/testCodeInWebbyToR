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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TextBoxMultilineandBorderStyle.htm
    public partial  class frmTextBoxMultilineandBorderStyle:Form
    {
        public frmTextBoxMultilineandBorderStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxMultilineandBorderStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxMultilineandBorderStyle";
            this.Text = "frmTextBoxMultilineandBorderStyle";
            this.Load += new System.EventHandler(this.frmTextBoxMultilineandBorderStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxMultilineandBorderStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
