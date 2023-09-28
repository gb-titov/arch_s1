using System.Drawing;
using S1.Stuff;

namespace S1.ModelElements
{
    internal class Flash
    {
        public Point3D Location { get; set; }
        public Angle3D Angle { get; set; }
        public Color Color { get; set; }
        public float Power { get; set; }

        public void Rotate(Angle3D angle) =>
            throw new NotImplementedException();
        
        public void Move(Point3D point) => 
            throw new NotImplementedException();
    }
    
}