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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RoutedEventsOnlyNumbers.htm
    public partial  class frmRoutedEventsOnlyNumbers:Form
    {
        public frmRoutedEventsOnlyNumbers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRoutedEventsOnlyNumbers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRoutedEventsOnlyNumbers";
            this.Text = "frmRoutedEventsOnlyNumbers";
            this.Load += new System.EventHandler(this.frmRoutedEventsOnlyNumbers_Load);
            this.ResumeLayout(false);

        }

        private void frmRoutedEventsOnlyNumbers_Load(object sender, EventArgs e)
        {

        }
    }
}
