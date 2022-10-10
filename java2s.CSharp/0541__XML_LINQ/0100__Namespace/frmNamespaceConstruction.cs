using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/NamespaceConstruction.htm
    public partial  class frmNamespaceConstruction:Form
    {
        public frmNamespaceConstruction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNamespaceConstruction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNamespaceConstruction";
            this.Text = "frmNamespaceConstruction";
            this.Load += new System.EventHandler(this.frmNamespaceConstruction_Load);
            this.ResumeLayout(false);

        }

        private void frmNamespaceConstruction_Load(object sender, EventArgs e)
        {

        }
    }
}
