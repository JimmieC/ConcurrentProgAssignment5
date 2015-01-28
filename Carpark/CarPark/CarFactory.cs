//Julian and James 15/01/20
using System;
using System.Threading.Tasks;
using System.Threading;

namespace CarPark
{
    class CarFactory
    {
        private Entrance entrance;
        public CarFactory(Entrance entrance)
        {
            this.entrance = entrance;
        }

        /// <summary>
        /// Creates the car task.
        /// </summary>
        public void CreateCarTask()
        {
            while(true)
            {
                Task<int> car = new Task<int>(StartTimer);
                entrance.Enqueue(car);
                Random random = new Random();
                Thread.Sleep(random.Next(100, 500));   
                
            }
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        /// <returns></returns>
        public int StartTimer()
        {
            Random random = new Random();
            int i = random.Next(1000, 2000);

            Thread.Sleep(i);
            return 1;
        }
    }
}
