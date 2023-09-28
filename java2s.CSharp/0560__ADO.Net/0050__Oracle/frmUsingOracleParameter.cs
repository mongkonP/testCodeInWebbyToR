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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingOracleParameter.htm
    public partial  class frmUsingOracleParameter:Form
    {
        public frmUsingOracleParameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingOracleParameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingOracleParameter";
            this.Text = "frmUsingOracleParameter";
            this.Load += new System.EventHandler(this.frmUsingOracleParameter_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingOracleParameter_Load(object sender, EventArgs e)
        {

        }
    }
}
