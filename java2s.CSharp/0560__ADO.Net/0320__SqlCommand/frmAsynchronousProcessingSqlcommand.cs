using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0320__SqlCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AsynchronousProcessingSqlcommand.htm
    public partial  class frmAsynchronousProcessingSqlcommand:Form
    {
        public frmAsynchronousProcessingSqlcommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousProcessingSqlcommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousProcessingSqlcommand";
            this.Text = "frmAsynchronousProcessingSqlcommand";
            this.Load += new System.EventHandler(this.frmAsynchronousProcessingSqlcommand_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousProcessingSqlcommand_Load(object sender, EventArgs e)
        {

        }
    }
}
