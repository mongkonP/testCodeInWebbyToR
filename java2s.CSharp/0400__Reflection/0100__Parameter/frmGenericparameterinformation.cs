using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0100__Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Genericparameterinformation.htm
    public partial  class frmGenericparameterinformation:Form
    {
        public frmGenericparameterinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericparameterinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericparameterinformation";
            this.Text = "frmGenericparameterinformation";
            this.Load += new System.EventHandler(this.frmGenericparameterinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericparameterinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
