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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RoutedEventsMousePosition.htm
    public partial  class frmRoutedEventsMousePosition:Form
    {
        public frmRoutedEventsMousePosition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRoutedEventsMousePosition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRoutedEventsMousePosition";
            this.Text = "frmRoutedEventsMousePosition";
            this.Load += new System.EventHandler(this.frmRoutedEventsMousePosition_Load);
            this.ResumeLayout(false);

        }

        private void frmRoutedEventsMousePosition_Load(object sender, EventArgs e)
        {

        }
    }
}
