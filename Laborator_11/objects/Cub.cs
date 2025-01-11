using OpenTK3_StandardTemplate_WinForms.helpers;
using System;
using System.Collections;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    class Cub
    {
        private ArrayList coordonates;
        private ArrayList colors;
        private PolygonMode currentPolygonState = PolygonMode.Line;
        private bool visibility;
        private string numeFisier;

        public Cub()
        {
            numeFisier = "cub.txt";
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
            for(int i=0; i<lines.Length; i++)
            {
                string[] coord = lines[i].Trim().Split(' ');
                int x = Convert.ToInt32(coord[0]);
                int y = Convert.ToInt32(coord[1]);
                int z = Convert.ToInt32(coord[2]);
                lst.Add(new Coords(x, y, z));

            }
            return lst;
        }
        public void Draw()
        {
            if (!visibility)
            {
                return;
            }
            GL.PolygonMode(MaterialFace.FrontAndBack, currentPolygonState);
            GL.Begin(PrimitiveType.Quads);
            for (int i = 0; i < coordonates.Count; i++)
            {
                GL.Color3((Color)colors[i]);
                Coords aux = (Coords)coordonates[i];
                GL.Vertex3(aux.X, aux.Y, aux.Z);

            }
            
        }
    }
}
