using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0040__Form
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/InheritedForm.htm
    public partial  class frmInheritedForm:Form
    {
        public frmInheritedForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInheritedForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInheritedForm";
            this.Text = "frmInheritedForm";
            this.Load += new System.EventHandler(this.frmInheritedForm_Load);
            this.ResumeLayout(false);

        }

        private void frmInheritedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
