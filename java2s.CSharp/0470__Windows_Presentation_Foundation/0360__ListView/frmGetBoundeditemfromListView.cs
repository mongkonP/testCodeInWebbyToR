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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GetBoundeditemfromListView.htm
    public partial  class frmGetBoundeditemfromListView:Form
    {
        public frmGetBoundeditemfromListView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetBoundeditemfromListView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetBoundeditemfromListView";
            this.Text = "frmGetBoundeditemfromListView";
            this.Load += new System.EventHandler(this.frmGetBoundeditemfromListView_Load);
            this.ResumeLayout(false);

        }

        private void frmGetBoundeditemfromListView_Load(object sender, EventArgs e)
        {

        }
    }
}
