using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2040__RoutedCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GetRoutedEventName.htm
    public partial  class frmGetRoutedEventName:Form
    {
        public frmGetRoutedEventName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetRoutedEventName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetRoutedEventName";
            this.Text = "frmGetRoutedEventName";
            this.Load += new System.EventHandler(this.frmGetRoutedEventName_Load);
            this.ResumeLayout(false);

        }

        private void frmGetRoutedEventName_Load(object sender, EventArgs e)
        {

        }
    }
}
