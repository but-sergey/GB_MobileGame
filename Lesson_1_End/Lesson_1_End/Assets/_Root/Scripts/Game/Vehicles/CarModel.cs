namespace Game.Vehicles
{
    internal class CarModel : IVehicle
    {
        private float _speed;

        public float Speed { get => _speed; }

        public CarModel(float speed) =>
            _speed = speed;
    }
}
