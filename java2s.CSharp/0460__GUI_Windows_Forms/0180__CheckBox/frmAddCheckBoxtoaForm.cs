using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0180__CheckBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddCheckBoxtoaForm.htm
    public partial  class frmAddCheckBoxtoaForm:Form
    {
        public frmAddCheckBoxtoaForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddCheckBoxtoaForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddCheckBoxtoaForm";
            this.Text = "frmAddCheckBoxtoaForm";
            this.Load += new System.EventHandler(this.frmAddCheckBoxtoaForm_Load);
            this.ResumeLayout(false);

        }

        private void frmAddCheckBoxtoaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
