using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0300__Draw_Image
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Resizeabitmapindrawing.htm
    public partial  class frmResizeabitmapindrawing:Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.CheckBox chkUseDoubleBuffering;
        public frmResizeabitmapindrawing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResizeabitmapindrawing
            // 
            this.components = new System.ComponentModel.Container();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.chkUseDoubleBuffering = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // chkUseDoubleBuffering
            // 
            this.chkUseDoubleBuffering.AutoSize = true;
            this.chkUseDoubleBuffering.Location = new System.Drawing.Point(12, 3);
            this.chkUseDoubleBuffering.Size = new System.Drawing.Size(127, 17);
            this.chkUseDoubleBuffering.TabIndex = 0;
            this.chkUseDoubleBuffering.Text = "Use Double Buffering";
            this.chkUseDoubleBuffering.UseVisualStyleBackColor = true;
            this.chkUseDoubleBuffering.CheckedChanged += new System.EventHandler(this.chkUseDoubleBuffering_CheckedChanged);
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 277);
            this.Controls.Add(this.chkUseDoubleBuffering);
            this.Text = "Double Buffering";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DoubleBuffering_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResizeabitmapindrawing";
            this.Text = "frmResizeabitmapindrawing";
            this.Load += new System.EventHandler(this.frmResizeabitmapindrawing_Load);
            this.ResumeLayout(false);

        }
        private int imageSize = 0;
        private Image image;

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            imageSize++;
            this.Invalidate();
        }

        private void DoubleBuffering_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillRectangle(Brushes.Yellow, new Rectangle(new Point(0, 0), this.ClientSize));
            g.DrawImage(image, 50, 50, 50 + imageSize, 50 + imageSize);
        }

        private void chkUseDoubleBuffering_CheckedChanged(object sender, EventArgs e)
        {
            this.DoubleBuffered = chkUseDoubleBuffering.Checked;
        }

        private void frmResizeabitmapindrawing_Load(object sender, EventArgs e)
        {
            image = Image.FromFile(@"Files\Image\3561841_emoji_expression_glared_shocked_surprised_icon.png");

            tmrRefresh.Start();
        }
    }
}
