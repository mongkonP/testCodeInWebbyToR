using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0120__OleDbParameter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OleDbParameterExample.htm
    public partial  class frmOleDbParameterExample:Form
    {
        public frmOleDbParameterExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOleDbParameterExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOleDbParameterExample";
            this.Text = "frmOleDbParameterExample";
            this.Load += new System.EventHandler(this.frmOleDbParameterExample_Load);
            this.ResumeLayout(false);

        }

        private void frmOleDbParameterExample_Load(object sender, EventArgs e)
        {

        }
    }
}
