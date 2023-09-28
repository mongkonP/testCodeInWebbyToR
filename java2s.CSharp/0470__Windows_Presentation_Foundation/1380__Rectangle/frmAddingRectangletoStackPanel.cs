using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddingRectangletoStackPanel.htm
    public partial  class frmAddingRectangletoStackPanel:Form
    {
        public frmAddingRectangletoStackPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingRectangletoStackPanel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingRectangletoStackPanel";
            this.Text = "frmAddingRectangletoStackPanel";
            this.Load += new System.EventHandler(this.frmAddingRectangletoStackPanel_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingRectangletoStackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
