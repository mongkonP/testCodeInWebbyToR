using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0240__Generic_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericMethodReflection.htm
    public partial  class frmGenericMethodReflection:Form
    {
        public frmGenericMethodReflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericMethodReflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericMethodReflection";
            this.Text = "frmGenericMethodReflection";
            this.Load += new System.EventHandler(this.frmGenericMethodReflection_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericMethodReflection_Load(object sender, EventArgs e)
        {

        }
    }
}
