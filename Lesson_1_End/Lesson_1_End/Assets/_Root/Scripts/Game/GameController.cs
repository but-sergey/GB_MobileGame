using Game.Vehicles;
using Game.InputLogic;
using Game.TapeBackground;
using Profile;
using Tool;

namespace Game
{
    internal class GameController : BaseController
    {
        public GameController(ProfilePlayer profilePlayer, Vehicle vehicle)
        {
            var leftMoveDiff = new SubscriptionProperty<float>();
            var rightMoveDiff = new SubscriptionProperty<float>();

            var tapeBackgroundController = new TapeBackgroundController(leftMoveDiff, rightMoveDiff);
            AddController(tapeBackgroundController);

            var inputGameController = new InputGameController(leftMoveDiff, rightMoveDiff, profilePlayer.VehicleModel);
            AddController(inputGameController);

            switch(vehicle)
            {
                case Vehicle.Car:
                default:
                    var carController = new CarController();
                    AddController(carController);
                    break;
                case Vehicle.Boat:
                    var boatController = new BoatController();
                    AddController(boatController);
                    break;
            }
        }
    }
}
