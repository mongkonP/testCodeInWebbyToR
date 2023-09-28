using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0540__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddtextintheTextBoxtotheListBox.htm
    public partial  class frmAddtextintheTextBoxtotheListBox:Form
    {
        public frmAddtextintheTextBoxtotheListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddtextintheTextBoxtotheListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddtextintheTextBoxtotheListBox";
            this.Text = "frmAddtextintheTextBoxtotheListBox";
            this.Load += new System.EventHandler(this.frmAddtextintheTextBoxtotheListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAddtextintheTextBoxtotheListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
