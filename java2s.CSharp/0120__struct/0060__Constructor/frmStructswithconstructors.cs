using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0060__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Structswithconstructors.htm
    public partial  class frmStructswithconstructors:Form
    {
        public frmStructswithconstructors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStructswithconstructors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStructswithconstructors";
            this.Text = "frmStructswithconstructors";
            this.Load += new System.EventHandler(this.frmStructswithconstructors_Load);
            this.ResumeLayout(false);

        }

        private void frmStructswithconstructors_Load(object sender, EventArgs e)
        {

        }
    }
}
