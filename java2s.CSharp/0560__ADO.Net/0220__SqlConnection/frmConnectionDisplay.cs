using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0220__SqlConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectionDisplay.htm
    public partial  class frmConnectionDisplay:Form
    {
        public frmConnectionDisplay()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectionDisplay
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectionDisplay";
            this.Text = "frmConnectionDisplay";
            this.Load += new System.EventHandler(this.frmConnectionDisplay_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectionDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
