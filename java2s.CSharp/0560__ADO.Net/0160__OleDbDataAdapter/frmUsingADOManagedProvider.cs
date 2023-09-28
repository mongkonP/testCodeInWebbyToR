using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0160__OleDbDataAdapter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingADOManagedProvider.htm
    public partial  class frmUsingADOManagedProvider:Form
    {
        public frmUsingADOManagedProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingADOManagedProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingADOManagedProvider";
            this.Text = "frmUsingADOManagedProvider";
            this.Load += new System.EventHandler(this.frmUsingADOManagedProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingADOManagedProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
