using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0280__Variable_Length_Parameters
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/VariableLengthParameterLists.htm
    public partial  class frmVariableLengthParameterLists:Form
    {
        public frmVariableLengthParameterLists()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVariableLengthParameterLists
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVariableLengthParameterLists";
            this.Text = "frmVariableLengthParameterLists";
            this.Load += new System.EventHandler(this.frmVariableLengthParameterLists_Load);
            this.ResumeLayout(false);

        }

        private void frmVariableLengthParameterLists_Load(object sender, EventArgs e)
        {

        }
    }
}
