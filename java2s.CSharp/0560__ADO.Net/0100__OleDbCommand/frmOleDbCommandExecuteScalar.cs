using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0100__OleDbCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OleDbCommandExecuteScalar.htm
    public partial  class frmOleDbCommandExecuteScalar:Form
    {
        public frmOleDbCommandExecuteScalar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOleDbCommandExecuteScalar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOleDbCommandExecuteScalar";
            this.Text = "frmOleDbCommandExecuteScalar";
            this.Load += new System.EventHandler(this.frmOleDbCommandExecuteScalar_Load);
            this.ResumeLayout(false);

        }

        private void frmOleDbCommandExecuteScalar_Load(object sender, EventArgs e)
        {

        }
    }
}
