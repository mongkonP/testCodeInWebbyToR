using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/EmptyForm.htm
    public partial  class frmEmptyForm:Form
    {
        public frmEmptyForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmptyForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmptyForm";
            this.Text = "frmEmptyForm";
            this.Load += new System.EventHandler(this.frmEmptyForm_Load);
            this.ResumeLayout(false);

        }

        private void frmEmptyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
