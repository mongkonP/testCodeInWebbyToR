using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0160__Thread_Priority
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Threadpriorities.htm
    public partial  class frmThreadpriorities:Form
    {
        public frmThreadpriorities()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadpriorities
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadpriorities";
            this.Text = "frmThreadpriorities";
            this.Load += new System.EventHandler(this.frmThreadpriorities_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadpriorities_Load(object sender, EventArgs e)
        {

        }
    }
}
