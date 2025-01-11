using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK3_StandardTemplate_WinForms.helpers;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    public class Rectangles
    {
        private ArrayList coordonates;
        private ArrayList colors;
        private PolygonMode currentPolygonState = PolygonMode.Fill;
        private bool visibility;
        private int[] textures = new int[2];
        private string numeFisier = "RectList.txt";

        public Rectangles()
        {
            coordonates = LoadFromFile();
            colors = new ArrayList();

            for (int i = 0; i < coordonates.Count; i++)
            {
                colors.Add(Randomizer.GetRandomColor());
            }

            visibility = true;
        }

        private ArrayList LoadFromFile()
        {
            ArrayList lst = new ArrayList();
            string[] lines = System.IO.File.ReadAllLines(numeFisier);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] coord = lines[i].Trim().Split(' ');
                int x = Convert.ToInt32(coord[0]);
                int y = Convert.ToInt32(coord[1]);
                int z = Convert.ToInt32(coord[2]);
                lst.Add(new Coords(x, y, z));
            }
            return lst;
        }

        public void SetVisibility(bool _visibility)
        {
            visibility = _visibility;
        }

        public void PolygonDrawingStyle(string style)
        {
            if (style == "line")
            {
                currentPolygonState = PolygonMode.Line;
            }
            else if (style == "surface")
            {
                currentPolygonState = PolygonMode.Fill;
            }
            else if (style == "point")
            {
                currentPolygonState = PolygonMode.Point;
            }
        }

        private void LoadTextures()
        {
            GL.GenTextures(textures.Length, textures);
            LoadTexture(textures[0], "brickTexture.jpg");
            LoadTexture(textures[1], "OpenGLtexture.png");
        }

        private void LoadTexture(int textureId, string filename)
        {
            Bitmap bmp = new Bitmap(filename);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                            ImageLockMode.ReadOnly,
                                            System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, textureId);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba,
                          bmp.Width, bmp.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                          PixelType.UnsignedByte, data.Scan0);

            bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (float)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (float)TextureMagFilter.Linear);
        }

        public void Draw()
        {
            if (!visibility) return;

            LoadTextures();
            GL.BindTexture(TextureTarget.Texture2D, textures[0]); // aplică prima textură
            GL.PolygonMode(MaterialFace.FrontAndBack, currentPolygonState);

            GL.Begin(PrimitiveType.Quads);
            for (int i = 0; i < 4; i++)
            {
                GL.Color3((Color)colors[i]);
                Coords aux = (Coords)coordonates[i];
                GL.TexCoord2(aux.X, aux.Y); // coordonatele texturii
                GL.Vertex3(aux.X, aux.Y, aux.Z);
            }
            GL.End();
        }
    }
}
