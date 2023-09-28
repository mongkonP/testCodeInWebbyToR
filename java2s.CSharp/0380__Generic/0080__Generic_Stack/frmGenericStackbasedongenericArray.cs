using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0080__Generic_Stack
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericStackbasedongenericArray.htm
    public partial  class frmGenericStackbasedongenericArray:Form
    {
        public frmGenericStackbasedongenericArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericStackbasedongenericArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericStackbasedongenericArray";
            this.Text = "frmGenericStackbasedongenericArray";
            this.Load += new System.EventHandler(this.frmGenericStackbasedongenericArray_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericStackbasedongenericArray_Load(object sender, EventArgs e)
        {

        }
    }
}
