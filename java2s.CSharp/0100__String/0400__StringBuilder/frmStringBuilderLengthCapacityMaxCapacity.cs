using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0400__StringBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringBuilderLengthCapacityMaxCapacity.htm
    public partial  class frmStringBuilderLengthCapacityMaxCapacity:Form
    {
        public frmStringBuilderLengthCapacityMaxCapacity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringBuilderLengthCapacityMaxCapacity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringBuilderLengthCapacityMaxCapacity";
            this.Text = "frmStringBuilderLengthCapacityMaxCapacity";
            this.Load += new System.EventHandler(this.frmStringBuilderLengthCapacityMaxCapacity_Load);
            this.ResumeLayout(false);

        }

        private void frmStringBuilderLengthCapacityMaxCapacity_Load(object sender, EventArgs e)
        {

        }
    }
}
