using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0080__EventLog
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Addentrytoeventloginsideaservice.htm
    public partial  class frmAddentrytoeventloginsideaservice:Form
    {
        public frmAddentrytoeventloginsideaservice()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddentrytoeventloginsideaservice
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddentrytoeventloginsideaservice";
            this.Text = "frmAddentrytoeventloginsideaservice";
            this.Load += new System.EventHandler(this.frmAddentrytoeventloginsideaservice_Load);
            this.ResumeLayout(false);

        }

        private void frmAddentrytoeventloginsideaservice_Load(object sender, EventArgs e)
        {

        }
    }
}
