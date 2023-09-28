using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0480__SqlDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/RetrievingaResultSetStreamUsingaDataReader.htm
    public partial  class frmRetrievingaResultSetStreamUsingaDataReader:Form
    {
        public frmRetrievingaResultSetStreamUsingaDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievingaResultSetStreamUsingaDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievingaResultSetStreamUsingaDataReader";
            this.Text = "frmRetrievingaResultSetStreamUsingaDataReader";
            this.Load += new System.EventHandler(this.frmRetrievingaResultSetStreamUsingaDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievingaResultSetStreamUsingaDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
