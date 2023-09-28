using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0080__OleDbConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/RetrievingDatafromaTextFile.htm
    public partial  class frmRetrievingDatafromaTextFile:Form
    {
        public frmRetrievingDatafromaTextFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievingDatafromaTextFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievingDatafromaTextFile";
            this.Text = "frmRetrievingDatafromaTextFile";
            this.Load += new System.EventHandler(this.frmRetrievingDatafromaTextFile_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievingDatafromaTextFile_Load(object sender, EventArgs e)
        {

        }
    }
}
