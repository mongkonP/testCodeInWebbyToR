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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/GetSchemaTablefromOleDbDataReader.htm
    public partial  class frmGetSchemaTablefromOleDbDataReader:Form
    {
        public frmGetSchemaTablefromOleDbDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetSchemaTablefromOleDbDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetSchemaTablefromOleDbDataReader";
            this.Text = "frmGetSchemaTablefromOleDbDataReader";
            this.Load += new System.EventHandler(this.frmGetSchemaTablefromOleDbDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmGetSchemaTablefromOleDbDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
