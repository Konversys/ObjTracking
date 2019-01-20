using ObjTracking.Model;
using ObjTracking.Objects.Model;
using ObjTracking.Objects.Model.Entities;
using ObjTracking.R;
using ObjTracking.Tracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ObjTracking
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            canvas.Background = new ImageBrush() { ImageSource = Images.Forest };
            controller = new Controller(canvas);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerAction);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            timer.Start();
        }
        public void TimerAction(object sender, EventArgs e)
        {
            controller.UpdateEntities(ref canvas);
            Detector.Detect(canvas, ref dataField);
        }
    }
}
