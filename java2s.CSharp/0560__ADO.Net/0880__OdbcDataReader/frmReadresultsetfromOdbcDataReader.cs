using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0880__OdbcDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ReadresultsetfromOdbcDataReader.htm
    public partial  class frmReadresultsetfromOdbcDataReader:Form
    {
        public frmReadresultsetfromOdbcDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadresultsetfromOdbcDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadresultsetfromOdbcDataReader";
            this.Text = "frmReadresultsetfromOdbcDataReader";
            this.Load += new System.EventHandler(this.frmReadresultsetfromOdbcDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmReadresultsetfromOdbcDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
