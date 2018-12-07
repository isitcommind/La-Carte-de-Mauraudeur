using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsApp
{
    public partial class CustomMapPage : ContentPage
    {
        public CustomMapPage()
        {
            InitializeComponent();

            var customMap = new CustomMap
            {
                MapType = MapType.Hybrid,
            };

            var position1 = new Position(36.4672, -116.8937);
            var position2 = new Position(51.7666636,10.5333312);
            var position3 = new Position(19.479488, -155.602829);
            var position4 = new Position(40.220390, -74.012085);
            
            var position6 = new Position(27.986065, 86.922623);

            var customPin6 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position6,
                    Label = "Use any way to inform others who can pass by that you are in some trouble by using anything u have to set fire or making signs",
                    Address = "Mount Everest, Nepal"
                },
               
            };


            var customPin1 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position1,
                    Label = "Unpack anything heavy and walk towards the highest point ",
                    Address = "Death Valley, California and Nevada, USA"
                },
               
            };


            var customPin2 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position2,
                    Label = "Unpack anything heavy and walk towards the highest point",
                    Address = "Skellig Michael, off the coast of Ireland"
                },
                
            };

            var customPin3 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position3,
                    Label = "Be careful of anything red and dont ever take close pictures and walk in the indiacted road",
                    Address = "Hawaii's Volcano Tours"
                },
            };

            var customPin4 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position4,
                    Label = "Just Be careful of the pointy shaped games",
                    Address = "Action Park, New Jersey, USA"
                },
            };

            

           

            customMap.CustomPins = new List<CustomPin>
            {
                customPin1,
                customPin2,
                customPin3,
                customPin4,
                customPin6,
               
            };

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                        new Position(36.8961, 10.1865), Distance.FromMiles(0.5)));

            Content = customMap;
        }
    }
}
