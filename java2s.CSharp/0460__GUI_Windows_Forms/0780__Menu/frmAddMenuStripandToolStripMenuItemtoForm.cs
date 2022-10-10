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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddMenuStripandToolStripMenuItemtoForm.htm
    public partial  class frmAddMenuStripandToolStripMenuItemtoForm:Form
    {
        public frmAddMenuStripandToolStripMenuItemtoForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddMenuStripandToolStripMenuItemtoForm
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddMenuStripandToolStripMenuItemtoForm";
            this.Text = "frmAddMenuStripandToolStripMenuItemtoForm";
            this.Load += new System.EventHandler(this.frmAddMenuStripandToolStripMenuItemtoForm_Load);
            this.ResumeLayout(false);

        }

        private void frmAddMenuStripandToolStripMenuItemtoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
