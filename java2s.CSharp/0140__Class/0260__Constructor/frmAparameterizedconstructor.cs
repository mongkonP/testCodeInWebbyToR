using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0260__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Aparameterizedconstructor.htm
    public partial  class frmAparameterizedconstructor:Form
    {
        public frmAparameterizedconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAparameterizedconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAparameterizedconstructor";
            this.Text = "frmAparameterizedconstructor";
            this.Load += new System.EventHandler(this.frmAparameterizedconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmAparameterizedconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
