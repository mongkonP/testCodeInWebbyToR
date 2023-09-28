using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0190__Region
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateaRegionobjectcutarectangularholeinitandfillit.htm
    public partial  class frmCreateaRegionobjectcutarectangularholeinitandfillit:Form
    {
        private RichTextBox richTextBox1;

        public frmCreateaRegionobjectcutarectangularholeinitandfillit()
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
            // frmCreateaRegionobjectcutarectangularholeinitandfillit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmCreateaRegionobjectcutarectangularholeinitandfillit";
            this.Text = "frmCreateaRegionobjectcutarectangularholeinitandfillit";
            this.Load += new System.EventHandler(this.frmCreateaRegionobjectcutarectangularholeinitandfillit_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaRegionobjectcutarectangularholeinitandfillit_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            Region r = new Region(new Rectangle(30, 30, 30, 60));
            r.Exclude(new Rectangle(40, 40, 10, 10));
            g.FillRegion(Brushes.Orange, r);
            richTextBox1.WriteLine("This Region: ");
            richTextBox1.WriteLine(r.IsInfinite(g) ? " - is infinite" : " - is finite");
            richTextBox1.WriteLine(r.IsEmpty(g) ? " - is empty" : " - is non-empty");

            PointF pf = new PointF(35.0f, 30.0f);
            richTextBox1.WriteLine((r.IsVisible(pf) ? " - includes" : " - excludes") + " the point (35.0, 50.0)");

            Rectangle rect = new Rectangle(25, 65, 15, 15);
            g.DrawRectangle(Pens.Black, rect);
            richTextBox1.WriteLine((r.IsVisible(rect) ? " - is visible" : " - is invisible") + " in the rectangle shown");

            r.Dispose();
        }
    }
}
