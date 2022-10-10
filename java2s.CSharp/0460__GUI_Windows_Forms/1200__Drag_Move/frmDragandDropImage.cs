using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1200__Drag_Move
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DragandDropImage.htm
    public partial  class frmDragandDropImage:Form
    {
        public frmDragandDropImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDragandDropImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDragandDropImage";
            this.Text = "frmDragandDropImage";
            this.Load += new System.EventHandler(this.frmDragandDropImage_Load);
            this.ResumeLayout(false);

        }

        private void frmDragandDropImage_Load(object sender, EventArgs e)
        {

        }
    }
}
