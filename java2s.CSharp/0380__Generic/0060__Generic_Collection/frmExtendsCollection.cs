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
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/ExtendsCollection.htm
    public partial  class frmExtendsCollection:Form
    {
        public frmExtendsCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExtendsCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExtendsCollection";
            this.Text = "frmExtendsCollection";
            this.Load += new System.EventHandler(this.frmExtendsCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmExtendsCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
