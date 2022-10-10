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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Implementtheserviceinterface.htm
    public partial  class frmImplementtheserviceinterface:Form
    {
        public frmImplementtheserviceinterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementtheserviceinterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementtheserviceinterface";
            this.Text = "frmImplementtheserviceinterface";
            this.Load += new System.EventHandler(this.frmImplementtheserviceinterface_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementtheserviceinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
