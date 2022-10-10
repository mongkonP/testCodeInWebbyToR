using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1740__Storyboard
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EventTriggerRoutedEventImageLoaded.htm
    public partial  class frmEventTriggerRoutedEventImageLoaded:Form
    {
        public frmEventTriggerRoutedEventImageLoaded()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventTriggerRoutedEventImageLoaded
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventTriggerRoutedEventImageLoaded";
            this.Text = "frmEventTriggerRoutedEventImageLoaded";
            this.Load += new System.EventHandler(this.frmEventTriggerRoutedEventImageLoaded_Load);
            this.ResumeLayout(false);

        }

        private void frmEventTriggerRoutedEventImageLoaded_Load(object sender, EventArgs e)
        {

        }
    }
}
