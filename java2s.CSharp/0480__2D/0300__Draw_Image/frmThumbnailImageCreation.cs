using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0300__Draw_Image
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/ThumbnailImageCreation.htm
    public partial  class frmThumbnailImageCreation:Form
    {
        public frmThumbnailImageCreation()
        {
            InitializeComponent();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 273);
            this.Text = "Thumbnails";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ThumbnailImageCreation_Paint);
            this.Load += new System.EventHandler(this.ThumbnailImageCreation_Load);
            this.ResumeLayout(false);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThumbnailImageCreation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThumbnailImageCreation";
            this.Text = "frmThumbnailImageCreation";
            this.Load += new System.EventHandler(this.frmThumbnailImageCreation_Load);
            this.ResumeLayout(false);

        }
        Image thumbnail;

        private void ThumbnailImageCreation_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"\Files\Image\3561853_emoji_emoticon_happy_laugh_icon.png");

            int thumbnailWidth = 200, thumbnailHeight = 100;

            thumbnail = img.GetThumbnailImage(thumbnailWidth, thumbnailHeight,
              null, IntPtr.Zero);

        }

        private void ThumbnailImageCreation_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(thumbnail, 10, 10);
        }
        private void frmThumbnailImageCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
