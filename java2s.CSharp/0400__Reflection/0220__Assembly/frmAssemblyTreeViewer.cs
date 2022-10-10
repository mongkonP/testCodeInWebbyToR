using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0220__Assembly
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/AssemblyTreeViewer.htm
    public partial  class frmAssemblyTreeViewer:Form
    {
        public frmAssemblyTreeViewer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyTreeViewer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyTreeViewer";
            this.Text = "frmAssemblyTreeViewer";
            this.Load += new System.EventHandler(this.frmAssemblyTreeViewer_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyTreeViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
