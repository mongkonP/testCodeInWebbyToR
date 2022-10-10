using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0160__Operator_Overload.C0080__Conversion_Operator_Overload
{
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/UserDefinedConversions.htm
    public partial  class frmUserDefinedConversions:Form
    {
        public frmUserDefinedConversions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUserDefinedConversions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUserDefinedConversions";
            this.Text = "frmUserDefinedConversions";
            this.Load += new System.EventHandler(this.frmUserDefinedConversions_Load);
            this.ResumeLayout(false);

        }

        private void frmUserDefinedConversions_Load(object sender, EventArgs e)
        {

        }
    }
}
