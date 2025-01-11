using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    public class Scene
    {
        private Color DEFAULT_BKG_COLOR = Color.LightGray;
        private GLControl viewport;

        public Scene()
        {
            viewport = new GLControl(new OpenTK.Graphics.GraphicsMode(32, 24, 0, 8));
            viewport.TabIndex = 0;
            viewport.Name = "mainViewport";
            viewport.BackColor = DEFAULT_BKG_COLOR;
            viewport.Location = new Point(12, 12);
            viewport.Size = new Size(800, 600);
            viewport.VSync = false;
        }

        public GLControl GetViewport()
        {
            return viewport;
        }

        public void Reset()
        {
            GL.ClearColor(DEFAULT_BKG_COLOR);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Enable(EnableCap.Texture2D);
        }

        public void Invalidate()
        {
            viewport.Invalidate();
        }
    }
}
