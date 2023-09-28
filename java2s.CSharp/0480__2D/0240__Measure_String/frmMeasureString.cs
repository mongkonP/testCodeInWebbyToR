using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0240__Measure_String
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/MeasureString.htm
    public partial  class frmMeasureString:Form
    {
        SizeF sz = new SizeF();
        public frmMeasureString()
        {
            InitializeComponent();
            Size = new Size(350, 200);

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "&Measure";
            btn.Location = new Point((ClientSize.Width / 2) - (btn.Width / 2), ClientSize.Height / 2);
            btn.Click += new EventHandler(btn_Click);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            string str = "www.java2s.com";
            PointF pt = new PointF(ClientSize.Width / 2, 50);
            Graphics g = e.Graphics;
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;

            Brush b = new SolidBrush(ForeColor);
            g.DrawString(str, Font, b, pt, fmt);
            sz = g.MeasureString(str, Font, pt, fmt);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The string size is " + sz.ToString());
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMeasureString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMeasureString";
            this.Text = "frmMeasureString";
            this.Load += new System.EventHandler(this.frmMeasureString_Load);
            this.ResumeLayout(false);

        }

        private void frmMeasureString_Load(object sender, EventArgs e)
        {

        }
    }
}
