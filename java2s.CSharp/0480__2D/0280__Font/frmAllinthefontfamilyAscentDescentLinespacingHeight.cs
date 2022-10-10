using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0280__Font
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/AllinthefontfamilyAscentDescentLinespacingHeight.htm
    public partial  class frmAllinthefontfamilyAscentDescentLinespacingHeight:Form
    {
        private System.ComponentModel.Container components = null;
        private RichTextBox richTextBox1;
        public frmAllinthefontfamilyAscentDescentLinespacingHeight()
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            this.Controls.Add(this.richTextBox1);
            // 
            // frmAllinthefontfamilyAscentDescentLinespacingHeight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllinthefontfamilyAscentDescentLinespacingHeight";
            this.Text = "frmAllinthefontfamilyAscentDescentLinespacingHeight";
            this.Load += new System.EventHandler(this.frmAllinthefontfamilyAscentDescentLinespacingHeight_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(392, 237);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }
        protected void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            FontFamily myFamily = new FontFamily("Verdana");
            Font myFont = new Font(myFamily, 12);

            int y = 0;
            int fontHeight = myFont.Height;

            this.Text = "Measurements are in GraphicsUnit." + myFont.Unit.ToString();

            g.DrawString("The Verdana family.", myFont, Brushes.Blue, 10, y);

            richTextBox1.WriteLine("Ascent for bold Verdana: " + myFamily.GetCellAscent(FontStyle.Bold));
            richTextBox1.WriteLine("Descent for bold Verdana: " + myFamily.GetCellDescent(FontStyle.Bold));
            richTextBox1.WriteLine("Line spacing for bold Verdana: " + myFamily.GetLineSpacing(FontStyle.Bold));
            richTextBox1.WriteLine("Height for bold Verdana: " + myFamily.GetEmHeight(FontStyle.Bold));
        }
        private void frmAllinthefontfamilyAscentDescentLinespacingHeight_Load(object sender, EventArgs e)
        {

        }
    }
}
