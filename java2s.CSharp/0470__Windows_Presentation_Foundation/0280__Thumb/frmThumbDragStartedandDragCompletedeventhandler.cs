using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0280__Thumb
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThumbDragStartedandDragCompletedeventhandler.htm
    public partial  class frmThumbDragStartedandDragCompletedeventhandler:Form
    {
        public frmThumbDragStartedandDragCompletedeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThumbDragStartedandDragCompletedeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThumbDragStartedandDragCompletedeventhandler";
            this.Text = "frmThumbDragStartedandDragCompletedeventhandler";
            this.Load += new System.EventHandler(this.frmThumbDragStartedandDragCompletedeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmThumbDragStartedandDragCompletedeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
