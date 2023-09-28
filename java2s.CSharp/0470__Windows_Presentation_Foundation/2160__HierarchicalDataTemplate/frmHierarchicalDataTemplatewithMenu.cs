using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2160__HierarchicalDataTemplate
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HierarchicalDataTemplatewithMenu.htm
    public partial  class frmHierarchicalDataTemplatewithMenu:Form
    {
        public frmHierarchicalDataTemplatewithMenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHierarchicalDataTemplatewithMenu
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHierarchicalDataTemplatewithMenu";
            this.Text = "frmHierarchicalDataTemplatewithMenu";
            this.Load += new System.EventHandler(this.frmHierarchicalDataTemplatewithMenu_Load);
            this.ResumeLayout(false);

        }

        private void frmHierarchicalDataTemplatewithMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
