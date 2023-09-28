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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PopulatingListViewrows.htm
    public partial  class frmPopulatingListViewrows:Form
    {
        public frmPopulatingListViewrows()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPopulatingListViewrows
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPopulatingListViewrows";
            this.Text = "frmPopulatingListViewrows";
            this.Load += new System.EventHandler(this.frmPopulatingListViewrows_Load);
            this.ResumeLayout(false);

        }

        private void frmPopulatingListViewrows_Load(object sender, EventArgs e)
        {

        }
    }
}
