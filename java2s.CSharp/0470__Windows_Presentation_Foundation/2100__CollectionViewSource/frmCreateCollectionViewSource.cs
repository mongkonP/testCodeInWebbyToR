using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2100__CollectionViewSource
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateCollectionViewSource.htm
    public partial  class frmCreateCollectionViewSource:Form
    {
        public frmCreateCollectionViewSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateCollectionViewSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateCollectionViewSource";
            this.Text = "frmCreateCollectionViewSource";
            this.Load += new System.EventHandler(this.frmCreateCollectionViewSource_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateCollectionViewSource_Load(object sender, EventArgs e)
        {

        }
    }
}
