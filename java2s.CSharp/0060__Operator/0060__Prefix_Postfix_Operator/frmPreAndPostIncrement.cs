using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0060__Prefix_Postfix_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/PreAndPostIncrement.htm
    public partial  class frmPreAndPostIncrement:Form
    {
        public frmPreAndPostIncrement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPreAndPostIncrement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPreAndPostIncrement";
            this.Text = "frmPreAndPostIncrement";
            this.Load += new System.EventHandler(this.frmPreAndPostIncrement_Load);
            this.ResumeLayout(false);

        }

        private void frmPreAndPostIncrement_Load(object sender, EventArgs e)
        {

        }
    }
}
