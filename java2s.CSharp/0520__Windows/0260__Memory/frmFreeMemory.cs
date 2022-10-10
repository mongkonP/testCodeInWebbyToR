using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0260__Memory
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/FreeMemory.htm
    public partial  class frmFreeMemory:Form
    {
        public frmFreeMemory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFreeMemory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFreeMemory";
            this.Text = "frmFreeMemory";
            this.Load += new System.EventHandler(this.frmFreeMemory_Load);
            this.ResumeLayout(false);

        }

        private void frmFreeMemory_Load(object sender, EventArgs e)
        {

        }
    }
}
