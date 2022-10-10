using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0120__Thread_Join
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseJointowaitforthreadstoend.htm
    public partial  class frmUseJointowaitforthreadstoend:Form
    {
        public frmUseJointowaitforthreadstoend()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseJointowaitforthreadstoend
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseJointowaitforthreadstoend";
            this.Text = "frmUseJointowaitforthreadstoend";
            this.Load += new System.EventHandler(this.frmUseJointowaitforthreadstoend_Load);
            this.ResumeLayout(false);

        }

        private void frmUseJointowaitforthreadstoend_Load(object sender, EventArgs e)
        {

        }
    }
}
