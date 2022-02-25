using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Module
{
    public class Application
    {
        public void Render(List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Render();

                //ShapeType type = shapes[i].ShapeType;
                //switch (type)
                //{
                //    case ShapeType.Rectangle:
                //        RenderRectangle((Rectangle)shapes[i]);
                //        return;
                //    case ShapeType.Circle:
                //        RenderCircle((Circle)shapes[i]);
                //        return;
                //}
            }
        }

        //private void RenderCircle(Circle circle)
        //{
        //    Console.WriteLine("Render circle...");
        //}

        //private void RenderRectangle(Rectangle rectangle)
        //{
        //    Console.WriteLine("Render rectangle...");
        //}
    }
}
