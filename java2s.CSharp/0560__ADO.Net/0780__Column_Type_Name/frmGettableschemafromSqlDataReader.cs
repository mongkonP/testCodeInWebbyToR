using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0780__Column_Type_Name
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/GettableschemafromSqlDataReader.htm
    public partial  class frmGettableschemafromSqlDataReader:Form
    {
        public frmGettableschemafromSqlDataReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettableschemafromSqlDataReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettableschemafromSqlDataReader";
            this.Text = "frmGettableschemafromSqlDataReader";
            this.Load += new System.EventHandler(this.frmGettableschemafromSqlDataReader_Load);
            this.ResumeLayout(false);

        }

        private void frmGettableschemafromSqlDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
