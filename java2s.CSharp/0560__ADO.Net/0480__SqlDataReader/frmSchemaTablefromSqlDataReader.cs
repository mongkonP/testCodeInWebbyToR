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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SchemaTablefromSqlDataReader.htm
    public partial  class frmSchemaTablefromSqlDataReader:Form
    {
        public frmSchemaTablefromSqlDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSchemaTablefromSqlDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSchemaTablefromSqlDataReader";
            this.Text = "frmSchemaTablefromSqlDataReader";
            this.Load += new System.EventHandler(this.frmSchemaTablefromSqlDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmSchemaTablefromSqlDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
