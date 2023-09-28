using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0560__DataAdapter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UpdatethroughSqlDataAdapter.htm
    public partial  class frmUpdatethroughSqlDataAdapter:Form
    {
        public frmUpdatethroughSqlDataAdapter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatethroughSqlDataAdapter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatethroughSqlDataAdapter";
            this.Text = "frmUpdatethroughSqlDataAdapter";
            this.Load += new System.EventHandler(this.frmUpdatethroughSqlDataAdapter_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatethroughSqlDataAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
