using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1180__Drag_Drop
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DragDropSample.htm
    public partial  class frmDragDropSample:Form
    {
        public frmDragDropSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDragDropSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDragDropSample";
            this.Text = "frmDragDropSample";
            this.Load += new System.EventHandler(this.frmDragDropSample_Load);
            this.ResumeLayout(false);

        }

        private void frmDragDropSample_Load(object sender, EventArgs e)
        {

        }
    }
}
