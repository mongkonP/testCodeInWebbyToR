using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericTypeReflection.htm
    public partial  class frmGenericTypeReflection:Form
    {
        public frmGenericTypeReflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericTypeReflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericTypeReflection";
            this.Text = "frmGenericTypeReflection";
            this.Load += new System.EventHandler(this.frmGenericTypeReflection_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericTypeReflection_Load(object sender, EventArgs e)
        {

        }
    }
}
