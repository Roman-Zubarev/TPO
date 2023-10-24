using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType _type;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _type = type;
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj as MilitaryPlane);
        }

        public override int GetHashCode()
        {
           return base.GetHashCode();
        }

        public MilitaryType GetPlaneType()
        {
            return _type;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + _type +
                    '}');
        }        
    }
}
