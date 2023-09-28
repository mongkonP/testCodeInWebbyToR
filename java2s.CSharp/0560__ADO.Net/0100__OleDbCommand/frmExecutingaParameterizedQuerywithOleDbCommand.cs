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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ExecutingaParameterizedQuerywithOleDbCommand.htm
    public partial  class frmExecutingaParameterizedQuerywithOleDbCommand:Form
    {
        public frmExecutingaParameterizedQuerywithOleDbCommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExecutingaParameterizedQuerywithOleDbCommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExecutingaParameterizedQuerywithOleDbCommand";
            this.Text = "frmExecutingaParameterizedQuerywithOleDbCommand";
            this.Load += new System.EventHandler(this.frmExecutingaParameterizedQuerywithOleDbCommand_Load);
            this.ResumeLayout(false);

        }

        private void frmExecutingaParameterizedQuerywithOleDbCommand_Load(object sender, EventArgs e)
        {

        }
    }
}
