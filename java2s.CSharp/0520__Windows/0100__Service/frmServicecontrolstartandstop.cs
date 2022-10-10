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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Servicecontrolstartandstop.htm
    public partial  class frmServicecontrolstartandstop:Form
    {
        public frmServicecontrolstartandstop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmServicecontrolstartandstop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmServicecontrolstartandstop";
            this.Text = "frmServicecontrolstartandstop";
            this.Load += new System.EventHandler(this.frmServicecontrolstartandstop_Load);
            this.ResumeLayout(false);

        }

        private void frmServicecontrolstartandstop_Load(object sender, EventArgs e)
        {

        }
    }
}
