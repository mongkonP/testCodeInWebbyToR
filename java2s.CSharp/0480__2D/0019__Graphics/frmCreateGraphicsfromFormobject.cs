using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateGraphicsfromFormobject.htm
    public partial  class frmCreateGraphicsfromFormobject:Form
    {
        bool bTracking;
        Point ptLast;
        public frmCreateGraphicsfromFormobject()
        {
            InitializeComponent();
            Text = "Scribble";
        }
        protected override void OnMouseDown(MouseEventArgs mea)
        {
            if (mea.Button != MouseButtons.Left)
                return;

            ptLast = new Point(mea.X, mea.Y);
            bTracking = true;
        }
        protected override void OnMouseMove(MouseEventArgs mea)
        {
            if (!bTracking)
                return;

            Point ptNew = new Point(mea.X, mea.Y);

            Graphics grfx = CreateGraphics();
            grfx.DrawLine(new Pen(ForeColor), ptLast, ptNew);
            grfx.Dispose();

            ptLast = ptNew;
        }
        protected override void OnMouseUp(MouseEventArgs mea)
        {
            bTracking = false;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateGraphicsfromFormobject
            // 
            this.ClientSize = new System.Drawing.Size(1063, 631);
            this.Name = "frmCreateGraphicsfromFormobject";
            this.Text = "frmCreateGraphicsfromFormobject";
            this.Load += new System.EventHandler(this.frmCreateGraphicsfromFormobject_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateGraphicsfromFormobject_Load(object sender, EventArgs e)
        {

        }
    }
}
