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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PanelZIndex.htm
    public partial  class frmPanelZIndex:Form
    {
        public frmPanelZIndex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPanelZIndex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPanelZIndex";
            this.Text = "frmPanelZIndex";
            this.Load += new System.EventHandler(this.frmPanelZIndex_Load);
            this.ResumeLayout(false);

        }

        private void frmPanelZIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
