using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0050__Oracle
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/NoConnectionPooling.htm
    public partial  class frmNoConnectionPooling:Form
    {
        public frmNoConnectionPooling()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNoConnectionPooling
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNoConnectionPooling";
            this.Text = "frmNoConnectionPooling";
            this.Load += new System.EventHandler(this.frmNoConnectionPooling_Load);
            this.ResumeLayout(false);

        }

        private void frmNoConnectionPooling_Load(object sender, EventArgs e)
        {

        }
    }
}
