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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CustomCommandbyKeyGestureandRoutedUICommand.htm
    public partial  class frmCustomCommandbyKeyGestureandRoutedUICommand:Form
    {
        public frmCustomCommandbyKeyGestureandRoutedUICommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomCommandbyKeyGestureandRoutedUICommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomCommandbyKeyGestureandRoutedUICommand";
            this.Text = "frmCustomCommandbyKeyGestureandRoutedUICommand";
            this.Load += new System.EventHandler(this.frmCustomCommandbyKeyGestureandRoutedUICommand_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomCommandbyKeyGestureandRoutedUICommand_Load(object sender, EventArgs e)
        {

        }
    }
}
