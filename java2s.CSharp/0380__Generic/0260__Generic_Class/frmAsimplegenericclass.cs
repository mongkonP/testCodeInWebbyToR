using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0260__Generic_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Asimplegenericclass.htm
    public partial  class frmAsimplegenericclass:Form
    {
        public frmAsimplegenericclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimplegenericclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimplegenericclass";
            this.Text = "frmAsimplegenericclass";
            this.Load += new System.EventHandler(this.frmAsimplegenericclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimplegenericclass_Load(object sender, EventArgs e)
        {

        }
    }
}
