using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int _passengersCapacity;

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            return  this.Equals(obj as PassengerPlane);
        }

        public override int GetHashCode()
        {     
            return base.GetHashCode();
        }

        public int PassengersCapacity()
        {
            return _passengersCapacity;
        }

       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + _passengersCapacity +
                    '}');
        }       
        
    }
}
