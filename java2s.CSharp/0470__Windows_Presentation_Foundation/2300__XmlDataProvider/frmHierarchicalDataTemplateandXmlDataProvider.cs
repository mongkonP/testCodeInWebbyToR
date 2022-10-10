using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2300__XmlDataProvider
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HierarchicalDataTemplateandXmlDataProvider.htm
    public partial  class frmHierarchicalDataTemplateandXmlDataProvider:Form
    {
        public frmHierarchicalDataTemplateandXmlDataProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHierarchicalDataTemplateandXmlDataProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHierarchicalDataTemplateandXmlDataProvider";
            this.Text = "frmHierarchicalDataTemplateandXmlDataProvider";
            this.Load += new System.EventHandler(this.frmHierarchicalDataTemplateandXmlDataProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmHierarchicalDataTemplateandXmlDataProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
