using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace FortuneMachine
{
    class GPS
    {
        private GeoCoordinateWatcher watcher;
        private Interface interfaceReference;

        public GPS(Interface mainInterface)
        {
            this.interfaceReference = mainInterface;
        }

        public void GetLocationDataEvent()
        {
            watcher = new System.Device.Location.GeoCoordinateWatcher();
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();
        }

        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Console.WriteLine("GPS : " + e.Position.Location.Latitude + " : " + e.Position.Location.Longitude);
            interfaceReference.Latitude = e.Position.Location.Latitude;
            interfaceReference.Longitude = e.Position.Location.Longitude;
            watcher.Stop();
        }
    }
}
