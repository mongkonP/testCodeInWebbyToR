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
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericInterface.htm
    public partial  class frmGenericInterface:Form
    {
        public frmGenericInterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericInterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericInterface";
            this.Text = "frmGenericInterface";
            this.Load += new System.EventHandler(this.frmGenericInterface_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
