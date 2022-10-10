using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0220__DLL
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Fiber.htm
    public partial  class frmFiber:Form
    {
        public frmFiber()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFiber
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFiber";
            this.Text = "frmFiber";
            this.Load += new System.EventHandler(this.frmFiber_Load);
            this.ResumeLayout(false);

        }

        private void frmFiber_Load(object sender, EventArgs e)
        {

        }
    }
}
