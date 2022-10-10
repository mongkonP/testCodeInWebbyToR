using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1640__Geometry
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LineGeometryDemo.htm
    public partial  class frmLineGeometryDemo:Form
    {
        public frmLineGeometryDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLineGeometryDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLineGeometryDemo";
            this.Text = "frmLineGeometryDemo";
            this.Load += new System.EventHandler(this.frmLineGeometryDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmLineGeometryDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
