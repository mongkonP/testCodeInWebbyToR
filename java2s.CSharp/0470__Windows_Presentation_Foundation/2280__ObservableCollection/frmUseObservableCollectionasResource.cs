using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2280__ObservableCollection
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseObservableCollectionasResource.htm
    public partial  class frmUseObservableCollectionasResource:Form
    {
        public frmUseObservableCollectionasResource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseObservableCollectionasResource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseObservableCollectionasResource";
            this.Text = "frmUseObservableCollectionasResource";
            this.Load += new System.EventHandler(this.frmUseObservableCollectionasResource_Load);
            this.ResumeLayout(false);

        }

        private void frmUseObservableCollectionasResource_Load(object sender, EventArgs e)
        {

        }
    }
}
