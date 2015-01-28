//Julian and James 15/01/20

namespace CarPark
{
    class Consumer
    {
        private CarPark carPark;

        public Consumer(CarPark carPark)
        {
            this.carPark = carPark;
        }

        /// <summary>
        /// Removes the car.
        /// </summary>
        public void KillCar()
        {
            while (true)
            {
                if (carPark.Count > 0)
                {
                    carPark.KillCar();    
                }
            }
        }
    }
}
