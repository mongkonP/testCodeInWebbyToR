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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ReadstringfromOracleDataReader.htm
    public partial  class frmReadstringfromOracleDataReader:Form
    {
        public frmReadstringfromOracleDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadstringfromOracleDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadstringfromOracleDataReader";
            this.Text = "frmReadstringfromOracleDataReader";
            this.Load += new System.EventHandler(this.frmReadstringfromOracleDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmReadstringfromOracleDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
