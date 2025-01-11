using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK3_StandardTemplate_WinForms.helpers;
using OpenTK3_StandardTemplate_WinForms.objects;

namespace OpenTK3_StandardTemplate_WinForms
{
    public partial class MainForm : Form
    {
        private Axes mainAxis;
        private Rectangles re;
        private Camera cam;
        private Scene scene;
        private Point mousePosition;
        private bool lightON;
        private bool lightOn_0;

        private float[] valuesAmbient0 = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };
        private float[] valuesDiffuse0 = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        private float[] valuesPosition0 = new float[] { 0.0f, 0.0f, 5.0f, 1.0f };

        public MainForm()
        {
            InitializeComponent();
            scene = new Scene();
            scene.GetViewport().Load += mainViewport_Load;
            scene.GetViewport().Paint += mainViewport_Paint;
            scene.GetViewport().MouseMove += mainViewport_MouseMove;
            this.Controls.Add(scene.GetViewport());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Randomizer.Init();
            cam = new Camera(scene.GetViewport());
            mainAxis = new Axes(true);
            re = new Rectangles();
        }

        private void setLight0Values()
        {
            GL.Light(LightName.Light0, LightParameter.Ambient, valuesAmbient0);
            GL.Light(LightName.Light0, LightParameter.Diffuse, valuesDiffuse0);
            GL.Light(LightName.Light0, LightParameter.Position, valuesPosition0);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
        }

        private void mainViewport_Load(object sender, EventArgs e)
        {
            scene.Reset();
        }

        private void mainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
            scene.Invalidate();
        }

        private void mainViewport_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            cam.SetView();
            if (lightON)
            {
                GL.Enable(EnableCap.Lighting);
            }
            else
            {
                GL.Disable(EnableCap.Lighting);
            }

            setLight0Values();

            if (enableRotation.Checked)
            {
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
            }

            if (rbFill.Checked)
            {
                re.PolygonDrawingStyle("surface");
            }
            else if (rbLine.Checked)
            {
                re.PolygonDrawingStyle("line");
            }
            else if (rbPoint.Checked)
            {
                re.PolygonDrawingStyle("point");
            }

            mainAxis.Draw();
            re.Draw();

            scene.GetViewport().SwapBuffers();
        }

        private void buttonLights_Click(object sender, EventArgs e)
        {
            lightON = !lightON;
            btnLights.Text = lightON ? "Iluminare ON" : "Iluminare OFF";
            scene.Invalidate();
        }

        private void btnSursa0_Click(object sender, EventArgs e)
        {
            lightOn_0 = !lightOn_0;
            btnSursa0.Text = lightOn_0 ? "Sursa 0 On" : "Sursa 0 Off";
            scene.Invalidate();
        }
    }
}
