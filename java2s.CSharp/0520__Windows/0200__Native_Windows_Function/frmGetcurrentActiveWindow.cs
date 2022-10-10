using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetcurrentActiveWindow.htm
    public partial  class frmGetcurrentActiveWindow:Form
    {
        public frmGetcurrentActiveWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetcurrentActiveWindow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetcurrentActiveWindow";
            this.Text = "frmGetcurrentActiveWindow";
            this.Load += new System.EventHandler(this.frmGetcurrentActiveWindow_Load);
            this.ResumeLayout(false);

        }

        private void frmGetcurrentActiveWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
