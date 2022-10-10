using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0580__Clock
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/1224hourclock.htm
    public partial  class frm1224hourclock:Form
    {
        private System.ComponentModel.Container components = null;
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
        private int FaceRadius = 450;    // size of the clock face
        private bool b24Hours = false;    // 24 hour clock face?
        private System.Windows.Forms.Button btnClockFormat;
        private System.Windows.Forms.Timer timer1;        // center of the clock
        private DateTime currentTime;    // used in more than one method
        public frm1224hourclock()
        {
            InitializeComponent();
            // use the user's choice of colors
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;

            timer1.Interval = 500;
            timer1.Enabled = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.components = new System.ComponentModel.Container();
            this.btnClockFormat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClockFormat
            // 
            this.btnClockFormat.Location = new System.Drawing.Point(8, 8);
            this.btnClockFormat.Name = "btnClockFormat";
            this.btnClockFormat.TabIndex = 1;
            this.btnClockFormat.Text = "24 Hours";
            this.btnClockFormat.Click += new System.EventHandler(this.btnClockFormat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                    this.btnClockFormat});
            // 
            // frm1224hourclock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frm1224hourclock";
            this.Text = "frm1224hourclock";
            this.Load += new System.EventHandler(this.frm1224hourclock_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SetScale(g);
            DrawFace(g);
            DrawTime(g, true);  // force an update
        }
        private void frm1224hourclock_Load(object sender, EventArgs e)
        {

        }

        private void SetScale(Graphics g)
        {
            // if the form is too small, do nothing
            if (Width == 0 || Height == 0)
                return;

            // set the origin at the center
            g.TranslateTransform(Width / 2, Height / 2);

            // set inches to the minimum of the width 
            // or height dividedby the dots per inch  
            float inches = Math.Min(Width / g.DpiX, Height / g.DpiX);

            // set the scale to a grid of 2000 by 2000 units
            g.ScaleTransform(
              inches * g.DpiX / 2000, inches * g.DpiY / 2000);
        }

        private void DrawFace(Graphics g)
        {
            // numbers are in forecolor except flash number in green
            // as the seconds go by.
            Brush brush = new SolidBrush(ForeColor);
            Font font = new Font("Arial", 40);
            float x, y;

            // new code
            int numHours = b24Hours ? 24 : 12;
            int deg = 360 / numHours;

            // for each of the hours on the clock face
            for (int i = 1; i <= numHours; i++)
            {
                // i = hour  30 degrees = offset per hour  
                // +90 to make 12 straight up
                x = GetCos(i * deg + 90) * FaceRadius;
                y = GetSin(i * deg + 90) * FaceRadius;

                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString(
                  i.ToString(), font, brush, -x, -y, format);

            }  // end for loop
        }    // end drawFace


        private void DrawTime(Graphics g, bool forceDraw)
        {

            //  length of the hands
            float hourLength = FaceRadius * 0.5f;
            float minuteLength = FaceRadius * 0.7f;
            float secondLength = FaceRadius * 0.9f;

            // set to back color to erase old hands first
            Pen hourPen = new Pen(BackColor);
            Pen minutePen = new Pen(BackColor);
            Pen secondPen = new Pen(BackColor);

            // set the arrow heads
            hourPen.EndCap = LineCap.ArrowAnchor;
            minutePen.EndCap = LineCap.ArrowAnchor;

            // hour hand is thicker
            hourPen.Width = 30;
            minutePen.Width = 20;

            // second hand 
            Brush secondBrush = new SolidBrush(BackColor);
            const int EllipseSize = 50;

            GraphicsState state;  // to to protect and to serve


            // 1 - delete the old time

            // delete the old second hand
            // figure out how far around to rotate to draw the second hand
            // save the current state, rotate, draw and then restore the state
            float rotation = GetSecondRotation();
            state = g.Save();
            g.RotateTransform(rotation);
            g.FillEllipse(
              secondBrush,
              -(EllipseSize / 2),
              -secondLength,
              EllipseSize,
              EllipseSize);
            g.Restore(state);

            DateTime newTime = DateTime.Now;
            bool newMin = false;  // has the minute changed?

            // if the minute has changed, set the flag
            if (newTime.Minute != currentTime.Minute)
                newMin = true;


            // if the minute has changed or you must draw anyway then you 
            // must first delete the old minute and hour hand
            if (newMin || forceDraw)
            {

                // figure out how far around to rotate to draw the minute hand
                // save the current state, rotate, draw and then restore the state
                rotation = GetMinuteRotation();
                state = g.Save();
                g.RotateTransform(rotation);
                g.DrawLine(minutePen, 0, 0, 0, -minuteLength);
                g.Restore(state);

                // figure out how far around to rotate to draw the hour hand
                // save the current state, rotate, draw and then restore the state
                rotation = GetHourRotation();
                state = g.Save();
                g.RotateTransform(rotation);
                g.DrawLine(hourPen, 0, 0, 0, -hourLength);
                g.Restore(state);
            }

            // step 2 - draw the new time
            currentTime = newTime;

            hourPen.Color = Color.Red;
            minutePen.Color = Color.Blue;
            secondPen.Color = Color.Green;
            secondBrush = new SolidBrush(Color.Green);

            // draw the new second hand
            // figure out how far around to rotate to draw the second hand
            // save the current state, rotate, draw and then restore the state
            state = g.Save();
            rotation = GetSecondRotation();
            g.RotateTransform(rotation);
            g.FillEllipse(
              secondBrush,
              -(EllipseSize / 2),
              -secondLength,
              EllipseSize,
              EllipseSize);
            g.Restore(state);

            // if the minute has changed or you must draw anyway then you 
            // must draw the new minute and hour hand
            if (newMin || forceDraw)
            {

                // figure out how far around to rotate to draw the minute hand
                // save the current state, rotate, draw and then restore the state
                state = g.Save();
                rotation = GetMinuteRotation();
                g.RotateTransform(rotation);
                g.DrawLine(minutePen, 0, 0, 0, -minuteLength);
                g.Restore(state);

                // figure out how far around to rotate to draw the hour hand
                // save the current state, rotate, draw and then restore the state
                state = g.Save();
                rotation = GetHourRotation();
                g.RotateTransform(rotation);
                g.DrawLine(hourPen, 0, 0, 0, -hourLength);
                g.Restore(state);
            }
        }

        // determine the rotation to draw the hour hand
        private float GetHourRotation()
        {
            // degrees depend on 24 vs. 12 hour clock
            float deg = b24Hours ? 15 : 30;
            float numHours = b24Hours ? 24 : 12;
            return (360f * currentTime.Hour / numHours +
              deg * currentTime.Minute / 60f);
        }

        private float GetMinuteRotation()
        {
            return (360f * currentTime.Minute / 60f);
        }

        private float GetSecondRotation()
        {
            return (360f * currentTime.Second / 60f);
        }

        private static float GetSin(float degAngle)
        {
            return (float)Math.Sin(Math.PI * degAngle / 180f);
        }

        private static float GetCos(float degAngle)
        {
            return (float)Math.Cos(Math.PI * degAngle / 180f);
        }

        private void btnClockFormat_Click(object sender, System.EventArgs e)
        {
            btnClockFormat.Text = b24Hours ? "24 Hour" : "12 Hour";
            b24Hours = !b24Hours;
            this.Invalidate();

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.Invalidate();

        }

    }
}
