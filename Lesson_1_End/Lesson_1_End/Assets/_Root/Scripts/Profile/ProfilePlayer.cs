using Game.Vehicles;
using Tool;

namespace Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> CurrentState;
        public readonly IVehicle VehicleModel;

        public ProfilePlayer(float speed, GameState initialState, Vehicle vehicle) : this(speed, initialState)
        {
            switch(vehicle)
            {
                case Vehicle.Car:
                    VehicleModel = new CarModel(speed);
                    break;
                case Vehicle.Boat:
                    VehicleModel = new BoatModel(speed);
                    break;
                default:
                    VehicleModel = new CarModel(speed);
                    break;
            }
        }

        public ProfilePlayer(float speed, GameState initialState) : this(speed)
        {
            CurrentState.Value = initialState;
        }

        public ProfilePlayer(float speed)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            VehicleModel = new CarModel(speed);
        }
    }
}
