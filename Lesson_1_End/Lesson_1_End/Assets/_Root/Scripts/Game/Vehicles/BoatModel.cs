namespace Game.Vehicles
{
    internal class BoatModel : IVehicle
    {
        private float _speed;

        public float Speed { get => _speed; }

        public BoatModel(float speed) =>
            _speed = speed;
    }
}
