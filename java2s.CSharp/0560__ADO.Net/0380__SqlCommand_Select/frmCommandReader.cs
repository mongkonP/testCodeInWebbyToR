using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0380__SqlCommand_Select
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CommandReader.htm
    public partial  class frmCommandReader:Form
    {
        public frmCommandReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCommandReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCommandReader";
            this.Text = "frmCommandReader";
            this.Load += new System.EventHandler(this.frmCommandReader_Load);
            this.ResumeLayout(false);

        }

        private void frmCommandReader_Load(object sender, EventArgs e)
        {

        }
    }
}
