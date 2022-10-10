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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SqlDataReader.htm
    public partial  class frmSqlDataReader:Form
    {
        public frmSqlDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSqlDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSqlDataReader";
            this.Text = "frmSqlDataReader";
            this.Load += new System.EventHandler(this.frmSqlDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmSqlDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
