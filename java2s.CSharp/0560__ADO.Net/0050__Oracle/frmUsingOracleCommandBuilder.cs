using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0050__Oracle
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingOracleCommandBuilder.htm
    public partial  class frmUsingOracleCommandBuilder:Form
    {
        public frmUsingOracleCommandBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingOracleCommandBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingOracleCommandBuilder";
            this.Text = "frmUsingOracleCommandBuilder";
            this.Load += new System.EventHandler(this.frmUsingOracleCommandBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingOracleCommandBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
