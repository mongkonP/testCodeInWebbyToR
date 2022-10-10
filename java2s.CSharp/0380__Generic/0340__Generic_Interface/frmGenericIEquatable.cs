using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0340__Generic_Interface
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericIEquatable.htm
    public partial  class frmGenericIEquatable:Form
    {
        public frmGenericIEquatable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericIEquatable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericIEquatable";
            this.Text = "frmGenericIEquatable";
            this.Load += new System.EventHandler(this.frmGenericIEquatable_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericIEquatable_Load(object sender, EventArgs e)
        {

        }
    }
}
