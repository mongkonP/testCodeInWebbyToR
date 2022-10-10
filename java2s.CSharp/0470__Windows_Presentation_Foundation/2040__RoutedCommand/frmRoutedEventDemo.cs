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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RoutedEventDemo.htm
    public partial  class frmRoutedEventDemo:Form
    {
        public frmRoutedEventDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRoutedEventDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRoutedEventDemo";
            this.Text = "frmRoutedEventDemo";
            this.Load += new System.EventHandler(this.frmRoutedEventDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmRoutedEventDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
