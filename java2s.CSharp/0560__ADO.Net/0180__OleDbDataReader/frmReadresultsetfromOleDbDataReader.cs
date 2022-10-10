using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0180__OleDbDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ReadresultsetfromOleDbDataReader.htm
    public partial  class frmReadresultsetfromOleDbDataReader:Form
    {
        public frmReadresultsetfromOleDbDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadresultsetfromOleDbDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadresultsetfromOleDbDataReader";
            this.Text = "frmReadresultsetfromOleDbDataReader";
            this.Load += new System.EventHandler(this.frmReadresultsetfromOleDbDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmReadresultsetfromOleDbDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
