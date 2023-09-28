using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0420__SqlCommandBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ShowSQL.htm
    public partial  class frmShowSQL:Form
    {
        public frmShowSQL()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowSQL
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowSQL";
            this.Text = "frmShowSQL";
            this.Load += new System.EventHandler(this.frmShowSQL_Load);
            this.ResumeLayout(false);

        }

        private void frmShowSQL_Load(object sender, EventArgs e)
        {

        }
    }
}
