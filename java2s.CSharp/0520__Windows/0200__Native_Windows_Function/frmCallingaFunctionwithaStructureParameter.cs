using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CallingaFunctionwithaStructureParameter.htm
    public partial  class frmCallingaFunctionwithaStructureParameter:Form
    {
        public frmCallingaFunctionwithaStructureParameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallingaFunctionwithaStructureParameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallingaFunctionwithaStructureParameter";
            this.Text = "frmCallingaFunctionwithaStructureParameter";
            this.Load += new System.EventHandler(this.frmCallingaFunctionwithaStructureParameter_Load);
            this.ResumeLayout(false);

        }

        private void frmCallingaFunctionwithaStructureParameter_Load(object sender, EventArgs e)
        {

        }
    }
}
