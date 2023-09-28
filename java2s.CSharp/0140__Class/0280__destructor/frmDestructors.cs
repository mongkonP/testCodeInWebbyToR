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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Destructors.htm
    public partial  class frmDestructors:Form
    {
        public frmDestructors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDestructors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDestructors";
            this.Text = "frmDestructors";
            this.Load += new System.EventHandler(this.frmDestructors_Load);
            this.ResumeLayout(false);

        }

        private void frmDestructors_Load(object sender, EventArgs e)
        {

        }
    }
}
