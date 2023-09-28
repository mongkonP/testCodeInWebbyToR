using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0380__Password_Field
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Passwordfieldsmatch.htm
    public partial  class frmPasswordfieldsmatch:Form
    {
        public frmPasswordfieldsmatch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPasswordfieldsmatch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPasswordfieldsmatch";
            this.Text = "frmPasswordfieldsmatch";
            this.Load += new System.EventHandler(this.frmPasswordfieldsmatch_Load);
            this.ResumeLayout(false);

        }

        private void frmPasswordfieldsmatch_Load(object sender, EventArgs e)
        {

        }
    }
}
