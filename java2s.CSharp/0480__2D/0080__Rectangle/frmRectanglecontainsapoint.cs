using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0080__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Rectanglecontainsapoint.htm
    public partial  class frmRectanglecontainsapoint:Form
    {
        public frmRectanglecontainsapoint()
        {
            InitializeComponent();
        }
        private RichTextBox richTextBox1;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmRectanglecontainsapoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRectanglecontainsapoint";
            this.Text = "frmRectanglecontainsapoint";
            this.Load += new System.EventHandler(this.frmRectanglecontainsapoint_Load);
            this.ResumeLayout(false);

        }

        private void frmRectanglecontainsapoint_Load(object sender, EventArgs e)
        {
            Rectangle r1 = new Rectangle(0, 0, 100, 100);
            Point pt3 = new Point(101, 101);

            if (r1.Contains(pt3))
                richTextBox1.WriteLine("Point is within the rect!");
            else
                richTextBox1.WriteLine("Point is not within the rect!");
        }
    }
}
