using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0160__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddaButton.htm
    public partial  class frmAddaButton:Form
    {
        public frmAddaButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddaButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddaButton";
            this.Text = "frmAddaButton";
            this.Load += new System.EventHandler(this.frmAddaButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddaButton_Load(object sender, EventArgs e)
        {

        }
    }
}
