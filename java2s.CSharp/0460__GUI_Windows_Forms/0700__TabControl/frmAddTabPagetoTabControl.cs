using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0700__TabControl
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddTabPagetoTabControl.htm
    public partial  class frmAddTabPagetoTabControl:Form
    {
        public frmAddTabPagetoTabControl()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddTabPagetoTabControl
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddTabPagetoTabControl";
            this.Text = "frmAddTabPagetoTabControl";
            this.Load += new System.EventHandler(this.frmAddTabPagetoTabControl_Load);
            this.ResumeLayout(false);

        }

        private void frmAddTabPagetoTabControl_Load(object sender, EventArgs e)
        {

        }
    }
}
