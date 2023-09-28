using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0780__Menu
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddMenutoForm.htm
    public partial  class frmAddMenutoForm:Form
    {
        public frmAddMenutoForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddMenutoForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddMenutoForm";
            this.Text = "frmAddMenutoForm";
            this.Load += new System.EventHandler(this.frmAddMenutoForm_Load);
            this.ResumeLayout(false);

        }

        private void frmAddMenutoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
