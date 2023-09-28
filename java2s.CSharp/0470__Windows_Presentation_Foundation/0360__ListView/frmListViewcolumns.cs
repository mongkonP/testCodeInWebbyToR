using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0360__ListView
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListViewcolumns.htm
    public partial  class frmListViewcolumns:Form
    {
        public frmListViewcolumns()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListViewcolumns
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListViewcolumns";
            this.Text = "frmListViewcolumns";
            this.Load += new System.EventHandler(this.frmListViewcolumns_Load);
            this.ResumeLayout(false);

        }

        private void frmListViewcolumns_Load(object sender, EventArgs e)
        {

        }
    }
}
