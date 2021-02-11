using System;
using System.Net;
using System.Xml;
//using System.Device.Location;

namespace FortuneMachine
{
    class GPS
    {
        private string IPQuery = "https://ipinfo.io/ip";
        private string templateGeoLocationQuery = "http://api.geoiplookup.net/?query=@IP@";
        private Interface mainInterface;

        public GPS(Interface mainInterface)
        {
            this.mainInterface = mainInterface;
        }

        private string GetPublicIP()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    Console.WriteLine("Requête : " + IPQuery);
                    return client.DownloadString(IPQuery);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur : " + ex.Message);
                    return "";
                }
            }
        }

        private void GetIPLocation()
        {
            string IP = GetPublicIP();
            string url = templateGeoLocationQuery.Replace("@IP@", IP);
            Console.WriteLine("Requête : " + url);
            XmlDocument XmlResponse = new XmlDocument();
            XmlResponse.Load(url);
            string latitude = XmlResponse.SelectSingleNode("ip/results/result/latitude").InnerText.Replace(".",",");
            string longitude = XmlResponse.SelectSingleNode("ip/results/result/longitude").InnerText.Replace(".", ",");
            mainInterface.Latitude = Convert.ToDouble(latitude);
            mainInterface.Longitude = Convert.ToDouble(longitude);
        }

        public void UpdateLocation()
        {
            GetIPLocation();
        }


        // /!\ - NOT WORKING WITH MONO /!\
        /*private GeoCoordinateWatcher watcher;
        private Interface interfaceReference;

        public GPS(Interface mainInterface)
        {
            this.interfaceReference = mainInterface;
        }

        public void GetLocationDataEvent()
        {
            watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();
        }

        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Console.WriteLine("GPS : " + e.Position.Location.Latitude + " : " + e.Position.Location.Longitude);
            interfaceReference.Latitude = e.Position.Location.Latitude;
            interfaceReference.Longitude = e.Position.Location.Longitude;
            watcher.Stop();
        }*/
    }
}
