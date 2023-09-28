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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoObservableCollectionandItemsSource.htm
    public partial  class frmBindtoObservableCollectionandItemsSource:Form
    {
        public frmBindtoObservableCollectionandItemsSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoObservableCollectionandItemsSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoObservableCollectionandItemsSource";
            this.Text = "frmBindtoObservableCollectionandItemsSource";
            this.Load += new System.EventHandler(this.frmBindtoObservableCollectionandItemsSource_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoObservableCollectionandItemsSource_Load(object sender, EventArgs e)
        {

        }
    }
}
