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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RoutedEventsKeyPressEvents.htm
    public partial  class frmRoutedEventsKeyPressEvents:Form
    {
        public frmRoutedEventsKeyPressEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRoutedEventsKeyPressEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRoutedEventsKeyPressEvents";
            this.Text = "frmRoutedEventsKeyPressEvents";
            this.Load += new System.EventHandler(this.frmRoutedEventsKeyPressEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmRoutedEventsKeyPressEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
