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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/MultipleDataAdapter.htm
    public partial  class frmMultipleDataAdapter:Form
    {
        public frmMultipleDataAdapter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultipleDataAdapter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultipleDataAdapter";
            this.Text = "frmMultipleDataAdapter";
            this.Load += new System.EventHandler(this.frmMultipleDataAdapter_Load);
            this.ResumeLayout(false);

        }

        private void frmMultipleDataAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
