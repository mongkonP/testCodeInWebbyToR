using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2400__Xaml
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetbuttonpropertieswithLinqstyle.htm
    public partial  class frmSetbuttonpropertieswithLinqstyle:Form
    {
        public frmSetbuttonpropertieswithLinqstyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetbuttonpropertieswithLinqstyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetbuttonpropertieswithLinqstyle";
            this.Text = "frmSetbuttonpropertieswithLinqstyle";
            this.Load += new System.EventHandler(this.frmSetbuttonpropertieswithLinqstyle_Load);
            this.ResumeLayout(false);

        }

        private void frmSetbuttonpropertieswithLinqstyle_Load(object sender, EventArgs e)
        {

        }
    }
}
