using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0720__Panel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WithoutPanelZIndex.htm
    public partial  class frmWithoutPanelZIndex:Form
    {
        public frmWithoutPanelZIndex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWithoutPanelZIndex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWithoutPanelZIndex";
            this.Text = "frmWithoutPanelZIndex";
            this.Load += new System.EventHandler(this.frmWithoutPanelZIndex_Load);
            this.ResumeLayout(false);

        }

        private void frmWithoutPanelZIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
