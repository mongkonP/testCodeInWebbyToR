using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0340__Generic_Interface
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/DeclaringaGenericwithMultipleTypeParameters.htm
    public partial  class frmDeclaringaGenericwithMultipleTypeParameters:Form
    {
        public frmDeclaringaGenericwithMultipleTypeParameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclaringaGenericwithMultipleTypeParameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclaringaGenericwithMultipleTypeParameters";
            this.Text = "frmDeclaringaGenericwithMultipleTypeParameters";
            this.Load += new System.EventHandler(this.frmDeclaringaGenericwithMultipleTypeParameters_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclaringaGenericwithMultipleTypeParameters_Load(object sender, EventArgs e)
        {

        }
    }
}
