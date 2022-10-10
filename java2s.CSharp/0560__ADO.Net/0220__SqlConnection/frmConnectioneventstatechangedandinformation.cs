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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Connectioneventstatechangedandinformation.htm
    public partial  class frmConnectioneventstatechangedandinformation:Form
    {
        public frmConnectioneventstatechangedandinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectioneventstatechangedandinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectioneventstatechangedandinformation";
            this.Text = "frmConnectioneventstatechangedandinformation";
            this.Load += new System.EventHandler(this.frmConnectioneventstatechangedandinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectioneventstatechangedandinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
