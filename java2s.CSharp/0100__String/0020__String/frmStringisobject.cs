using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringisobject.htm
    public partial  class frmStringisobject:Form
    {
        public frmStringisobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringisobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringisobject";
            this.Text = "frmStringisobject";
            this.Load += new System.EventHandler(this.frmStringisobject_Load);
            this.ResumeLayout(false);

        }

        private void frmStringisobject_Load(object sender, EventArgs e)
        {

        }
    }
}
