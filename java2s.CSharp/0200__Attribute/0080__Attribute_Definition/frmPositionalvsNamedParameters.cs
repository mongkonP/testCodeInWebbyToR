using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0080__Attribute_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/PositionalvsNamedParameters.htm
    public partial  class frmPositionalvsNamedParameters:Form
    {
        public frmPositionalvsNamedParameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPositionalvsNamedParameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPositionalvsNamedParameters";
            this.Text = "frmPositionalvsNamedParameters";
            this.Load += new System.EventHandler(this.frmPositionalvsNamedParameters_Load);
            this.ResumeLayout(false);

        }

        private void frmPositionalvsNamedParameters_Load(object sender, EventArgs e)
        {

        }
    }
}
