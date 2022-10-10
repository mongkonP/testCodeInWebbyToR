using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0080__struct_initialization
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Usethistoreferencestructsconstructor.htm
    public partial  class frmUsethistoreferencestructsconstructor:Form
    {
        public frmUsethistoreferencestructsconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethistoreferencestructsconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethistoreferencestructsconstructor";
            this.Text = "frmUsethistoreferencestructsconstructor";
            this.Load += new System.EventHandler(this.frmUsethistoreferencestructsconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethistoreferencestructsconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
