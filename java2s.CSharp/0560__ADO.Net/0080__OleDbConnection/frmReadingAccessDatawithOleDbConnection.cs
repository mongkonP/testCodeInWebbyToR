using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0080__OleDbConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ReadingAccessDatawithOleDbConnection.htm
    public partial  class frmReadingAccessDatawithOleDbConnection:Form
    {
        public frmReadingAccessDatawithOleDbConnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingAccessDatawithOleDbConnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingAccessDatawithOleDbConnection";
            this.Text = "frmReadingAccessDatawithOleDbConnection";
            this.Load += new System.EventHandler(this.frmReadingAccessDatawithOleDbConnection_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingAccessDatawithOleDbConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
