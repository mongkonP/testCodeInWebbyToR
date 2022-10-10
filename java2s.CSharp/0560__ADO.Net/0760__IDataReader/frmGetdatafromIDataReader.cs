using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0760__IDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/GetdatafromIDataReader.htm
    public partial  class frmGetdatafromIDataReader:Form
    {
        public frmGetdatafromIDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetdatafromIDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetdatafromIDataReader";
            this.Text = "frmGetdatafromIDataReader";
            this.Load += new System.EventHandler(this.frmGetdatafromIDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmGetdatafromIDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
