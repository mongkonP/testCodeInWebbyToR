using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0640__DataTable
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/FilterSort.htm
    public partial  class frmFilterSort:Form
    {
        public frmFilterSort()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFilterSort
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFilterSort";
            this.Text = "frmFilterSort";
            this.Load += new System.EventHandler(this.frmFilterSort_Load);
            this.ResumeLayout(false);

        }

        private void frmFilterSort_Load(object sender, EventArgs e)
        {

        }
    }
}
