//Julian and James 15/01/20
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CarPark
{
    class Entrance
    {
        Queue<Task> carQueue;
        private CarPark carpark;
        private delegate void Updatecount(string s, Label x);
        private Label label;

        public Entrance(CarPark carpark, Label label)
        {
            this.carpark = carpark;
            this.label = label;
            carQueue = new Queue<Task>();
        }

        /// <summary>
        /// Enqueues the specified car.
        /// </summary>
        /// <param name="thecar">The thecar.</param>
        public void Enqueue(Task thecar)
        {
            lock (carQueue)
            {
                if (carQueue.Count < 50)
                {
                    carQueue.Enqueue(thecar);
                    label.Invoke(new Updatecount((i, j) => { j.Text = i; }),
                    new object[] { carQueue.Count().ToString(), label });
                    Monitor.Pulse(carQueue);
                }
                else Monitor.Pulse(carQueue);
            }
            
        }

        /// <summary>
        /// Dequeues a car.
        /// </summary>
        public void Dequeue()
        {
            while (true)
            {
                lock(carQueue)
                {
                    label.Invoke(new Updatecount((i, j) => { j.Text = i; }),
                        new object[] {carQueue.Count().ToString(), label});
                    bool success = false;
                    Task car = carQueue.Dequeue();
                    while (!success)
                    {
                        if (carQueue.Count > 0)
                        {
                            if (carpark.ParkCar(car))
                            {
                                success = true;
                                Monitor.Pulse(carQueue);
                            }
                        }
                        else Monitor.Pulse(carQueue);
                    }
                }
                
                Thread.Sleep(500);
            }
        }
    }
}
