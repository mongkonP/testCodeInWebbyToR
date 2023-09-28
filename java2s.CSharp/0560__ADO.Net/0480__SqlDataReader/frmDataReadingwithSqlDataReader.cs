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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataReadingwithSqlDataReader.htm
    public partial  class frmDataReadingwithSqlDataReader:Form
    {
        public frmDataReadingwithSqlDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataReadingwithSqlDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataReadingwithSqlDataReader";
            this.Text = "frmDataReadingwithSqlDataReader";
            this.Load += new System.EventHandler(this.frmDataReadingwithSqlDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmDataReadingwithSqlDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
