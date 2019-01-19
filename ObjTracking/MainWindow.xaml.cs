using ObjTracking.Model;
using ObjTracking.Objects.Model;
using ObjTracking.Objects.Model.Entities;
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
            canvas.Background = new ImageBrush() { ImageSource = Images.Forest };
            entities = new List<Entity>();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerAction);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            timer.Start();

            int h = (int)canvas.Height;
            int w = (int)canvas.Width;
            entities.Add(new Bird(w, h));
            entities.Add(new Wolf(w, h));
            entities.Add(new Bird(w, h));
            entities.Add(new Bird(w, h));
            entities.Add(new Bull(w, h));
            entities.Add(new Owl(w, h));
            entities.Add(new Bear(w, h));
            entities.Add(new Owl(w, h));
            entities.Add(new Duck(w, h));
            entities.Add(new Owl(w, h));
            entities.Add(new Cat(w, h));
            entities.Add(new Bulldog(w, h));
            entities.Add(new Bear(w, h));
            entities.Add(new Bird(w, h));
            entities.Add(new Chicken(w, h));
            entities.Add(new Bear(w, h));
            entities.Add(new Cat(w, h));
            entities.Add(new Bird(w, h));
        }
        public void TimerAction(object sender, EventArgs e)
        {
            canvas.Children.Clear();
            foreach (var item in entities)
            {
                item.ShiftVector(3);
                canvas.Children.Add(item.GetCanvas());
            }
        }
    }
}
