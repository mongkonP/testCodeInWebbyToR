using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0100__Service
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Simplestservice.htm
    public partial  class frmSimplestservice:Form
    {
        public frmSimplestservice()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimplestservice
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimplestservice";
            this.Text = "frmSimplestservice";
            this.Load += new System.EventHandler(this.frmSimplestservice_Load);
            this.ResumeLayout(false);

        }

        private void frmSimplestservice_Load(object sender, EventArgs e)
        {

        }
    }
}
