using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2001__Bind_to_Collection
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CollectionViewSourceBinding.htm
    public partial  class frmCollectionViewSourceBinding:Form
    {
        public frmCollectionViewSourceBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCollectionViewSourceBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCollectionViewSourceBinding";
            this.Text = "frmCollectionViewSourceBinding";
            this.Load += new System.EventHandler(this.frmCollectionViewSourceBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmCollectionViewSourceBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
