using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Creatingamethodwithareferenceargument.htm
    public partial  class frmCreatingamethodwithareferenceargument:Form
    {
        public frmCreatingamethodwithareferenceargument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingamethodwithareferenceargument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingamethodwithareferenceargument";
            this.Text = "frmCreatingamethodwithareferenceargument";
            this.Load += new System.EventHandler(this.frmCreatingamethodwithareferenceargument_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingamethodwithareferenceargument_Load(object sender, EventArgs e)
        {

        }
    }
}
