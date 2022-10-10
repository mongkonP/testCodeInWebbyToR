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
    //http://www.java2s.com/Tutorial/CSharp/0160__Operator-Overload/UserDefinedConversionsConversionLookup.htm
    public partial  class frmUserDefinedConversionsConversionLookup:Form
    {
        public frmUserDefinedConversionsConversionLookup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUserDefinedConversionsConversionLookup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUserDefinedConversionsConversionLookup";
            this.Text = "frmUserDefinedConversionsConversionLookup";
            this.Load += new System.EventHandler(this.frmUserDefinedConversionsConversionLookup_Load);
            this.ResumeLayout(false);

        }

        private void frmUserDefinedConversionsConversionLookup_Load(object sender, EventArgs e)
        {

        }
    }
}
