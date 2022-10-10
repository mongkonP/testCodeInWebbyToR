using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0080__Form_Paint
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OverridePaintmethodforForm.htm
    public partial  class frmOverridePaintmethodforForm:Form
    {
        public frmOverridePaintmethodforForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverridePaintmethodforForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverridePaintmethodforForm";
            this.Text = "frmOverridePaintmethodforForm";
            this.Load += new System.EventHandler(this.frmOverridePaintmethodforForm_Load);
            this.ResumeLayout(false);

        }

        private void frmOverridePaintmethodforForm_Load(object sender, EventArgs e)
        {

        }
    }
}
