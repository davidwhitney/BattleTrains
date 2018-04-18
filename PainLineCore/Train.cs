namespace PainLineCore
{
    public class Train
    {
        private int _targetSpeed;
        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                _targetSpeed = value;
            }
        }

        public int DistanceTravelled { get; internal set; }

        public void Tick()
        {
            if (_speed < _targetSpeed)
            {
                _speed++;
            }

            if (_speed > _targetSpeed)
            {
                _speed--;
            }

            DistanceTravelled += _speed;
        }

        public void SetSpeed(int targetSpeed)
        {
            _targetSpeed = targetSpeed;
        }
    }
}