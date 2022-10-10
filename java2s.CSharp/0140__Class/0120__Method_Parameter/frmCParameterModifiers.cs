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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/CParameterModifiers.htm
    public partial  class frmCParameterModifiers:Form
    {
        public frmCParameterModifiers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCParameterModifiers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCParameterModifiers";
            this.Text = "frmCParameterModifiers";
            this.Load += new System.EventHandler(this.frmCParameterModifiers_Load);
            this.ResumeLayout(false);

        }

        private void frmCParameterModifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
