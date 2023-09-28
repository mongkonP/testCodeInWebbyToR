using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0900__ResultSet_to_Xml
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SqlCommandExecuteXmlReader.htm
    public partial  class frmSqlCommandExecuteXmlReader:Form
    {
        public frmSqlCommandExecuteXmlReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSqlCommandExecuteXmlReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSqlCommandExecuteXmlReader";
            this.Text = "frmSqlCommandExecuteXmlReader";
            this.Load += new System.EventHandler(this.frmSqlCommandExecuteXmlReader_Load);
            this.ResumeLayout(false);

        }

        private void frmSqlCommandExecuteXmlReader_Load(object sender, EventArgs e)
        {

        }
    }
}
