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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RoutedEventsFocusevent.htm
    public partial  class frmRoutedEventsFocusevent:Form
    {
        public frmRoutedEventsFocusevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRoutedEventsFocusevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRoutedEventsFocusevent";
            this.Text = "frmRoutedEventsFocusevent";
            this.Load += new System.EventHandler(this.frmRoutedEventsFocusevent_Load);
            this.ResumeLayout(false);

        }

        private void frmRoutedEventsFocusevent_Load(object sender, EventArgs e)
        {

        }
    }
}
