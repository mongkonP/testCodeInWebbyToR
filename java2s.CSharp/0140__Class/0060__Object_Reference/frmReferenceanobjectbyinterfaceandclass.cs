using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0060__Object_Reference
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Referenceanobjectbyinterfaceandclass.htm
    public partial  class frmReferenceanobjectbyinterfaceandclass:Form
    {
        public frmReferenceanobjectbyinterfaceandclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferenceanobjectbyinterfaceandclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferenceanobjectbyinterfaceandclass";
            this.Text = "frmReferenceanobjectbyinterfaceandclass";
            this.Load += new System.EventHandler(this.frmReferenceanobjectbyinterfaceandclass_Load);
            this.ResumeLayout(false);

        }

        private void frmReferenceanobjectbyinterfaceandclass_Load(object sender, EventArgs e)
        {

        }
    }
}
