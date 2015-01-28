//Julian and James 15/01/20
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPark
{
    class CarPark
    {
        private int parkPos;
        private object aLock;
        private Task[] carArray;
        private Label _label;
        public int Count { get; private set; }
        private delegate void Updatecount(string s, Label x);

        private int condition;

        private int nmbrArray;

        public CarPark(Label label)
        {
            condition = 50;
            _label = label;
            carArray = new Task[condition];
            aLock = new object();
            nmbrArray = 0;
            
        }

        /// <summary>
        /// Parks the car.
        /// </summary>
        /// <param name="carTask">The car task.</param>
        /// <returns></returns>
        public bool ParkCar(Task carTask)
        {
           
            lock (aLock)
            {
                
                while (nmbrArray >= condition)
                {
                    Monitor.Wait(aLock);
                }

                if (carArray[parkPos] == null)
                {
                    //park car 
                    carArray[parkPos] = carTask;
                    carTask.Start();
                    
                    nmbrArray ++;
                    Count = nmbrArray;
                    parkPos = (parkPos + 1)%carArray.Length;
                    _label.Invoke(new Updatecount((i, j) => { j.Text = i; }),
                    new object[] { nmbrArray.ToString(), _label });
                    Monitor.Pulse(aLock);
                    return true;
                }

                parkPos = (parkPos + 1) % carArray.Length;
                Monitor.Pulse(aLock);
                return false;
            }
        }

        /// <summary>
        /// Removes the car.
        /// </summary>
        public void KillCar()
        {
            lock (aLock)
            {
                if (carArray.Any()) //If any tasks are finished
                {
                    for (int x = 0; x < carArray.Count(); x++) //loop through array
                    {
                        if (carArray[x] != null)//if the task at this position is not null
                        {
                            if (carArray[x].IsCompleted)//And the task is completed
                            {
                                carArray[x] = null; //null that position
                                nmbrArray--;        //decrement the counter
                                Count = nmbrArray;  //adjust 
                               
                            }
                        }
                    }
                    _label.Invoke(new Updatecount((i, j) => { j.Text = i; }),
                               new object[] { nmbrArray.ToString(), _label });
                }
                Monitor.Pulse(aLock);
            }
        }
    }
}
