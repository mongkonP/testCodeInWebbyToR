using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0320__Word
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/WordApplication.htm
    public partial  class frmWordApplication:Form
    {
        public frmWordApplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWordApplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWordApplication";
            this.Text = "frmWordApplication";
            this.Load += new System.EventHandler(this.frmWordApplication_Load);
            this.ResumeLayout(false);

        }

        private void frmWordApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
