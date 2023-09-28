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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/InsertButtontoaPanel.htm
    public partial  class frmInsertButtontoaPanel:Form
    {
        public frmInsertButtontoaPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertButtontoaPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertButtontoaPanel";
            this.Text = "frmInsertButtontoaPanel";
            this.Load += new System.EventHandler(this.frmInsertButtontoaPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertButtontoaPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
