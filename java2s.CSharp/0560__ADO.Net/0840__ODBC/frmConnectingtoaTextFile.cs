using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0840__ODBC
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectingtoaTextFile.htm
    public partial  class frmConnectingtoaTextFile:Form
    {
        public frmConnectingtoaTextFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectingtoaTextFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectingtoaTextFile";
            this.Text = "frmConnectingtoaTextFile";
            this.Load += new System.EventHandler(this.frmConnectingtoaTextFile_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectingtoaTextFile_Load(object sender, EventArgs e)
        {

        }
    }
}
