//Julian and James 15/01/20
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace CarPark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            CarPark carPark = new CarPark(lblEntrance5);

            Entrance entrance1 = new Entrance(carPark, lblEntrance1);
            Entrance entrance2 = new Entrance(carPark, lblEntrance2);
            Entrance entrance3 = new Entrance(carPark, lblEntrance3);
            Entrance entrance4 = new Entrance(carPark, lblEntrance4);

            CarFactory carFactory1 = new CarFactory(entrance1);
            CarFactory carFactory2 = new CarFactory(entrance2);
            CarFactory carFactory3 = new CarFactory(entrance3);
            CarFactory carFactory4 = new CarFactory(entrance4);

            Consumer consumerThread = new Consumer(carPark); 

            Thread killTask = new Thread(consumerThread.KillCar); killTask.Start();

            Task addCarToQueue1 = new Task(carFactory1.CreateCarTask); addCarToQueue1.Start();
            Task addCarToQueue2 = new Task(carFactory2.CreateCarTask); addCarToQueue2.Start();
            Task addCarToQueue3 = new Task(carFactory3.CreateCarTask); addCarToQueue3.Start();
            Task addCarToQueue4 = new Task(carFactory4.CreateCarTask); addCarToQueue4.Start();

            Task parkCar1 = new Task(entrance1.Dequeue); parkCar1.Start();
            Task parkCar2 = new Task(entrance2.Dequeue); parkCar2.Start();
            Task parkCar3 = new Task(entrance3.Dequeue); parkCar3.Start();
            Task parkCar4 = new Task(entrance4.Dequeue); parkCar4.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
