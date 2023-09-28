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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TextBoxcancelevent.htm
    public partial  class frmTextBoxcancelevent:Form
    {
        public frmTextBoxcancelevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextBoxcancelevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextBoxcancelevent";
            this.Text = "frmTextBoxcancelevent";
            this.Load += new System.EventHandler(this.frmTextBoxcancelevent_Load);
            this.ResumeLayout(false);

        }

        private void frmTextBoxcancelevent_Load(object sender, EventArgs e)
        {

        }
    }
}
