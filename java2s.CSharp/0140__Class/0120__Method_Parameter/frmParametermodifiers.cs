using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Parametermodifiers.htm
    public partial  class frmParametermodifiers:Form
    {
        public frmParametermodifiers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmParametermodifiers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmParametermodifiers";
            this.Text = "frmParametermodifiers";
            this.Load += new System.EventHandler(this.frmParametermodifiers_Load);
            this.ResumeLayout(false);

        }

        private void frmParametermodifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
