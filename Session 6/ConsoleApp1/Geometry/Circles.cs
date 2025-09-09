using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInheritance.Geometry
{
    public interface DisplayedObject
    {
        public Color Colour { get; set; }
        public void drawToScreen(object canvas);
        //{
        //    //do things. make methods to display this thing on screen
        //}
        public string GetLabelText();
        //{
        //    return "This is a thing! On screen!";
        //}
    }
    public interface ILikeable
    {
        public void like(object socialMediaContext);
    }

    public class Ellipse
    {
        public Point Centre { get; set; }
        public double AxisLength1 { get; private set; }
        public double AxisLength2 { get; private set; }
        public Ellipse(Point centre, double axis1, double axis2) {
            Centre = centre;
            AxisLength1 = axis1;
            AxisLength2 = axis2;
        }
        public double GetArea()
        {
            return AxisLength1 * AxisLength2 * Math.PI;
        }
        public virtual string GetLabelText()
        {
            return $"Ellipse (centre {Centre}, radii {AxisLength1} and {AxisLength2}) ";
        }
    }
    // is-a
    public class Circle : Ellipse, DisplayedObject, ILikeable
    {
        public Color Colour { get; set; }
        public Circle(double radius) : base(new Point(), radius, radius) { }
        public Circle(Point centre, double radius) : base(centre, radius, radius) { }
        public override string GetLabelText()
        {
            return $"Circle (centre {Centre}, radius {AxisLength1}) ";
        }
        public void drawToScreen(object canvas) { }

        public void like(object email)
        {
            //email.body.append(GetLabelText());
        }
    }
    public class ZuckerbergPost : ILikeable
    {
        public void like(object socialMediaContext)
        {
            throw new NotImplementedException();
        }
    }
}
