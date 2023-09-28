using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0280__destructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Updatestaticfieldinthedeconstructor.htm
    public partial  class frmUpdatestaticfieldinthedeconstructor:Form
    {
        public frmUpdatestaticfieldinthedeconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatestaticfieldinthedeconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatestaticfieldinthedeconstructor";
            this.Text = "frmUpdatestaticfieldinthedeconstructor";
            this.Load += new System.EventHandler(this.frmUpdatestaticfieldinthedeconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatestaticfieldinthedeconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
