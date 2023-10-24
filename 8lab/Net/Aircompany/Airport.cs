using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        private List<Plane> _Planes;

        public Airport(IEnumerable<Plane> planes)
        {
            _Planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {
            return (List<PassengerPlane>)_Planes.Where(plane => plane.GetType() == typeof(PassengerPlane));
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            return (List<MilitaryPlane>)_Planes.Where(plane => plane.GetType() == typeof(MilitaryPlane));
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPassengersPlanes().Aggregate((w, x) => w.PassengersCapacity() > x.PassengersCapacity() ? w : x);             
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
           return (List<MilitaryPlane>)GetMilitaryPlanes().Where(plane => plane.GetPlaneType() == MilitaryType.Transport);

        }

        public Airport SortByMaxDistance()
        {
            return new Airport(_Planes.OrderBy(w => w.MaxFlightDistance()));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(_Planes.OrderBy(w => w.GetMaxSpeed()));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(_Planes.OrderBy(w => w.MaxLoadCapacity()));
        }


        public IEnumerable<Plane> GetPlanes()
        {
            return _Planes;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", _Planes.Select(x => x.GetModel())) +
                    '}';
        }
    }
}
