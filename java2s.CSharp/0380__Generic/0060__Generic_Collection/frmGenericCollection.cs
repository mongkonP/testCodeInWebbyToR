using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0060__Generic_Collection
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericCollection.htm
    public partial  class frmGenericCollection:Form
    {
        public frmGenericCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericCollection";
            this.Text = "frmGenericCollection";
            this.Load += new System.EventHandler(this.frmGenericCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
