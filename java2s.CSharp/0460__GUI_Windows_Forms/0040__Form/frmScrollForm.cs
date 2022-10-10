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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ScrollForm.htm
    public partial  class frmScrollForm:Form
    {
        public frmScrollForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScrollForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScrollForm";
            this.Text = "frmScrollForm";
            this.Load += new System.EventHandler(this.frmScrollForm_Load);
            this.ResumeLayout(false);

        }

        private void frmScrollForm_Load(object sender, EventArgs e)
        {

        }
    }
}
