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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoObservableCollection.htm
    public partial  class frmBindtoObservableCollection:Form
    {
        public frmBindtoObservableCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoObservableCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoObservableCollection";
            this.Text = "frmBindtoObservableCollection";
            this.Load += new System.EventHandler(this.frmBindtoObservableCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoObservableCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
