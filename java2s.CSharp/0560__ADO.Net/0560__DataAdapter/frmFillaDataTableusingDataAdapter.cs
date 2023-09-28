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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/FillaDataTableusingDataAdapter.htm
    public partial  class frmFillaDataTableusingDataAdapter:Form
    {
        public frmFillaDataTableusingDataAdapter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillaDataTableusingDataAdapter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillaDataTableusingDataAdapter";
            this.Text = "frmFillaDataTableusingDataAdapter";
            this.Load += new System.EventHandler(this.frmFillaDataTableusingDataAdapter_Load);
            this.ResumeLayout(false);

        }

        private void frmFillaDataTableusingDataAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
