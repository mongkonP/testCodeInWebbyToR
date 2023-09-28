using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0060__Point
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/PointCeilingRoundTruncate.htm
    public partial  class frmPointCeilingRoundTruncate:Form
    {
        private RichTextBox richTextBox1;

        public frmPointCeilingRoundTruncate()
        {
            InitializeComponent();
        }
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
            // frmPointCeilingRoundTruncate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmPointCeilingRoundTruncate";
            this.Text = "frmPointCeilingRoundTruncate";
            this.Load += new System.EventHandler(this.frmPointCeilingRoundTruncate_Load);
            this.ResumeLayout(false);

        }

        private void frmPointCeilingRoundTruncate_Load(object sender, EventArgs e)
        {
            PointF pt1 = new PointF(30.6f, 30.8f);
            PointF pt2 = new PointF(50.3f, 60.7f);
            PointF pt3 = new PointF(110.3f, 80.5f);
            Point pt4 = Point.Ceiling(pt1);
            Point pt5 = Point.Round(pt2);
            Point pt6 = Point.Truncate(pt3);
            richTextBox1.WriteLine("Value of pt4: " + pt4.ToString());
            richTextBox1.WriteLine("Value of pt5: " + pt5.ToString());
            richTextBox1.WriteLine("Value of pt6: " + pt6.ToString());
        }
    }
}
