using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity
{
    public partial class RayTraceForm : Form
    {
        Pen blackPen = new Pen(Color.Black);
        Pen redPen = new Pen(Color.Red);
        Brush brush = new SolidBrush(Color.Black);
        private bool Running = false;
        private NBodySystem Universe;
        private int Factor;
        private double HalfFactor;
        private double Shift;
        private double TimeInterval = 1;
        private readonly double EarthRadius = 6371000;
        private readonly double EarthMass = 5.972E+24;
        private readonly double EarthStartAngle = 0;
        private readonly double EarthStartVelocity = 12.5;
        private readonly double MoonDistance = 384402000;
        private readonly double MoonMass = 7.342E+22;
        private readonly double MoonRadius = 1737100;
        private readonly double MoonVelocity = 1022;
        private readonly double MoonStartAngle = Math.PI;
        private bool DoStep;
        private const double TwoPi = Math.PI * 2;
        private const double IssHeight = 408000;
        private const double IssSpeed = 7660;

        public RayTraceForm()
        {
            InitializeComponent();
            this.Resizing();
            //this.canvas1.Invalidate();
        }

        private void Resizing()
        {
            this.Factor = canvas1.ClientSize.Width; //rayTraceCanvas.Width > rayTraceCanvas.Height ? rayTraceCanvas.Width : rayTraceCanvas.Height;
            this.HalfFactor = this.Factor / (double)2;
            this.Shift = (canvas1.ClientSize.Width - canvas1.ClientSize.Height) / 2;
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (this.Running)
            {
                this.startStopBtn.Enabled = false;
                this.startStopBtn.Text = "Stopping";
                this.Running = false;
            }
            else
            {
                this.Start();
            }
        }

        private void Started()
        {
        }

        private void Stopped()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                this.Running = false;
                this.startStopBtn.Text = "Start";
                this.startStopBtn.Enabled = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }));
        }

        private async void Start()
        {
            var payloadStartSpeed = int.Parse(FiringSpeedTxtBox.Text);
            var payloadStartAngle = DegressToRadians(int.Parse(FiringAngleTxtBox.Text));
            var bodies = new[]
            {
                new Body
                {
                    Id = 0,
                    Coord = new Coord(),
                    CurrentVector = new Vector(EarthStartVelocity, EarthStartAngle),
                    Mass = EarthMass,
                    Radius = EarthRadius
                },
                new Body
                {
                    Id = 1,
                    Coord = new Coord(0, EarthRadius+IssHeight),
                    Mass = 1,
                    Radius = 1,
                    CurrentVector = new Vector(payloadStartSpeed, payloadStartAngle),
                    InfluencingVectors = new List<Influence> { new Influence { BodyId = 0, Vector = new Vector(EarthStartVelocity, EarthStartAngle) } }
                },
                new Body
                {
                    Id = 2,
                    Coord = new Coord(0, MoonDistance),
                    Mass = MoonMass,
                    Radius = MoonRadius,
                    CurrentVector = new Vector { Direction = MoonStartAngle, Velocity = MoonVelocity }
                }
            };
            var nBodyParams = new NBodyParameters
            {
                UpdateUi = UpdateForm,
                NewtonianCalculator = new NewtonianCalculator(TimeInterval),
                ShouldStop = () => !Running,
                Stopped = Stopped,
                PauseAt = PauseAt,
                Stop = () => { },
                TimeInterval = () => TimeInterval,
                Bodies = bodies
            };
            Universe = new NBodySystem(nBodyParams);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Running = true;
            startStopBtn.Text = "Stop";
            await Universe.Start();
        }

        private long PauseAt(long currentIteration)
        {
            if(!Running)
            {
                return 0;
            }

            this.Invoke((MethodInvoker)(() =>
            {
                this.CurrentIterationTxtBox.Text = currentIteration.ToString();
                this.TPlusTxtBox.Text = TimeSpan.FromSeconds(currentIteration).ToString();
            }));

            if (this.PlayRadio.Checked)
            {
                return long.Parse(this.MaxIterationsTxtBox.Text) + 1;
            }

            if (this.DoStep)
            {
                this.DoStep = false;
                return ++currentIteration;
            }

            return currentIteration;
        }

        private void UpdateForm(ICollection<Body> bodies)
        {
            try
            {
                var earth = bodies.First(b => b.Id == 0);
                var payload = bodies.First(b => b.Id == 1);
                var moon = bodies.First(b => b.Id == 2);
                var payloadHeight = NewtonianCalculator.PythagoreanDistance(earth, payload) - earth.Radius;
                var moonHeight = NewtonianCalculator.PythagoreanDistance(moon, payload) - earth.Radius;
                Invoke((MethodInvoker)(() =>
                {
                    MoonHeightDisplayTxtBox.Text = DoubleToString(Math.Round(moonHeight, 2), "m", "km");
                    MoonXdisplayTxtBox.Text = DoubleToString(Math.Round(moon.Coord.x, 2), "m", "km");
                    MoonYdisplayTxtBox.Text = DoubleToString(Math.Round(moon.Coord.y, 2), "m", "km");
                    MoonSpeedTxtBox.Text = DoubleToString(Math.Round(moon.CurrentVector.Velocity, 2), "ms", "kms");
                    EarthHeightDisplayTxtBox.Text = (earth.Radius / 1000).ToString("0,0 km");
                    EarthXdisplayTxtBox.Text = DoubleToString(Math.Round(earth.Coord.x, 2), "m", "km");
                    EarthYdisplayTxtBox.Text = DoubleToString(Math.Round(earth.Coord.y, 2), "m", "km");
                    EarthSpeedTxtBox.Text = DoubleToString(Math.Round(earth.CurrentVector.Velocity, 2), "ms", "kms");
                    PayloadXdisplayTxtBox.Text = DoubleToString(Math.Round(payload.Coord.x, 2), "m", "km");
                    PayloadYdisplayTxtBox.Text = DoubleToString(Math.Round(payload.Coord.y, 2), "m", "km");
                    PayloadSpeedTxtBox.Text = DoubleToString(Math.Round(payload.CurrentVector.Velocity, 2), "ms", "kms");
                    PayloadHeightDisplayTxtBox.Text = DoubleToString(Math.Round(payloadHeight, 2), "m", "km");
                    Update();
                }));
            }
            catch (Exception e) { }
        }

        private string DoubleToString(double value, string units, string thousands)
        {
            return Math.Abs(value) > 1000 ? (value / 1000).ToString("#,0.00 " + thousands)
                : value.ToString("#,0.00 " + units);
        }

        private void DrawLine(Coord a, Coord b, int count)
        {
            var pen = count == 0 ? blackPen : redPen;
            DrawLine(ScaleXVal(a.x), ScaleYVal(a.y), ScaleXVal(b.x), ScaleYVal(b.y), pen);
        }

        private void DrawLine(int x, int y, int x2, int y2, Pen pen = null)
        {
            var points = new[] { new Point(x, y), new Point(x2, y2) };
            //g.DrawLines(pen ?? this.blackPen, points);
        }

        private void Canvas_Paint(ICollection<Body> bodies)
        {
            canvas1.Image = null;
            //canvas1.Refresh();
            int wid = canvas1.ClientSize.Width;
            int hgt = canvas1.ClientSize.Height;

            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                DrawBodies(gr, bodies);
            }
            canvas1.Image = bm;
            canvas1.Refresh();
        }

        private void DrawBodies(Graphics gr, ICollection<Body> bodies)
        {
            //base.OnPaint(e);
            //gr.DrawRectangle(Pens.Brown, ScaleXVal(-1), ScaleYVal(-1), (float)Factor, (float)Factor);
            //gr.DrawEllipse(
            //    Pens.Blue,
            //    ScaleXVal(-1),
            //    ScaleYVal(-1),
            //    (float)Factor,
            //    (float)Factor);
            foreach (var body in bodies)
            {
                if (double.IsNaN(body.Coord.x) || double.IsNaN(body.Coord.y))
                {
                    throw new InvalidProgramException();
                }
                var x = ScaleXVal(body.Coord.x);
                var y = ScaleYVal(body.Coord.y);
                x = x > canvas1.Width ? canvas1.Width : x;
                y = y > canvas1.Height ? canvas1.Height : y;
                x = x < 0 ? 0 : x;
                y = y < 0 ? 0 : y;
                gr.FillRectangle(this.brush, x, y, 2, 2);
            }
            //rayTraceCanvas.OnPaint(e);
        }


        private double DescaleX(int pixelVal)
        {
            var x = pixelVal - HalfFactor;
            return x / HalfFactor;
        }
        private double DescaleY(int pixelVal)
        {
            var x = pixelVal - HalfFactor + this.Shift;
            return (x / HalfFactor);
        }

        private int ScaleXVal(double coordVal)
        {
            return (int)((coordVal * HalfFactor) + HalfFactor);
        }
        private int ScaleYVal(double coordVal)
        {
            return (int)((coordVal * HalfFactor) + HalfFactor - this.Shift);
        }

        private void RayTraceForm_Load(object sender, EventArgs e)
        {
            //rayTraceCanvas_Paint();
            Form1_Load(sender, e);
        }

        private const int period = 24;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Redraw when resized.
            this.ResizeRedraw = true;            
        }

        private void canvas1_Resize(object sender, EventArgs e)
        {
            Resizing();
            //rayTraceCanvas_Paint();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //this.Universe.Reset();
        }

        private void StepRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.StepBtn.Enabled = ((RadioButton)sender).Enabled;
        }

        private void StepBtn_Click(object sender, EventArgs e)
        {
            this.DoStep = true;
        }

        private void RayTraceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Running = false;
        }

        private double DegressToRadians(double degress)
        {
            return FixAngle(((degress - 90) / 180) * Math.PI);
        }

        private static double FixAngle(double angle)
        {
            angle = angle > TwoPi ? angle - TwoPi : angle;
            angle = angle < 0 ? angle + TwoPi : angle;
            return angle;
        }

        private void ScaleSlider_Scroll(object sender, EventArgs e)
        {
            var slider = sender as TrackBar;
            ScaleTxtBox.Text = slider.Value.ToString();
        }
    }
}
