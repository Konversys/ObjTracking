using ObjTracking.Model;
using ObjTracking.Model.Entities;
using ObjTracking.R;
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
        List<Entity> entities;
        public MainWindow()
        {
            InitializeComponent();
            entities = new List<Entity>();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerAction);
            timer.Interval = new TimeSpan(0, 0, 100);
            timer.Start();

            double h = canvas.Height;
            double w = canvas.Width;
            entities.Add(new Cat((uint)w, (uint)h));
            entities.Add(new Wolf((uint)w, (uint)h));
            entities.Add(new Wolf((uint)w, (uint)h));
            entities.Add(new Cat((uint)w, (uint)h));
            entities.Add(new Cat((uint)w, (uint)h));
            RefreshCanvas();
        }
        public void TimerAction(object sender, EventArgs e)
        {
            entities = Move.ShiftRand(entities, 10, 10);
            RefreshCanvas();
        }

        public void RefreshCanvas()
        {
            canvas.Children.Clear();
            foreach (var item in entities)
            {
                canvas.Children.Add(item.GetCanvas());
            }
        }
    }
}
