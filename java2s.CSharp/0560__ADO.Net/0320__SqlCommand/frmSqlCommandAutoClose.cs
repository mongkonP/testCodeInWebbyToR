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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SqlCommandAutoClose.htm
    public partial  class frmSqlCommandAutoClose:Form
    {
        public frmSqlCommandAutoClose()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSqlCommandAutoClose
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSqlCommandAutoClose";
            this.Text = "frmSqlCommandAutoClose";
            this.Load += new System.EventHandler(this.frmSqlCommandAutoClose_Load);
            this.ResumeLayout(false);

        }

        private void frmSqlCommandAutoClose_Load(object sender, EventArgs e)
        {

        }
    }
}
