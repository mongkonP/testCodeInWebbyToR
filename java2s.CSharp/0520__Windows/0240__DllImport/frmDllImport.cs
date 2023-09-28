using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0240__DllImport
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/DllImport.htm
    public partial  class frmDllImport:Form
    {
        public frmDllImport()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDllImport
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDllImport";
            this.Text = "frmDllImport";
            this.Load += new System.EventHandler(this.frmDllImport_Load);
            this.ResumeLayout(false);

        }

        private void frmDllImport_Load(object sender, EventArgs e)
        {

        }
    }
}
