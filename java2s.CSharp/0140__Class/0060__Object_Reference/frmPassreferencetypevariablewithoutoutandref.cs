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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Passreferencetypevariablewithoutoutandref.htm
    public partial  class frmPassreferencetypevariablewithoutoutandref:Form
    {
        public frmPassreferencetypevariablewithoutoutandref()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassreferencetypevariablewithoutoutandref
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassreferencetypevariablewithoutoutandref";
            this.Text = "frmPassreferencetypevariablewithoutoutandref";
            this.Load += new System.EventHandler(this.frmPassreferencetypevariablewithoutoutandref_Load);
            this.ResumeLayout(false);

        }

        private void frmPassreferencetypevariablewithoutoutandref_Load(object sender, EventArgs e)
        {

        }
    }
}
