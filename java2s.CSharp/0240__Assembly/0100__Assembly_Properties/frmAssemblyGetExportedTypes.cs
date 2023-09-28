using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0100__Assembly_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/AssemblyGetExportedTypes.htm
    public partial  class frmAssemblyGetExportedTypes:Form
    {
        public frmAssemblyGetExportedTypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyGetExportedTypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyGetExportedTypes";
            this.Text = "frmAssemblyGetExportedTypes";
            this.Load += new System.EventHandler(this.frmAssemblyGetExportedTypes_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyGetExportedTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
