using BeamTracker;
using ObjTracking.Model;
using ObjTracking.R;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace ObjTracking
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntityController entityController;
        Frame frame;
        EntityTemplates objects;
        TrackerController trackerController;

        public MainWindow()
        {
            InitializeComponent();
            canvas.Background = new ImageBrush() { ImageSource = Images.Forest };
            entityController = new EntityController(canvas);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerAction);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            timer.Start();

            trackerController = new TrackerController();
            // Добавление объектов в список шаблонов
            objects = new EntityTemplates();
            objects.Add("Утка", Images.Duck);
            objects.Add("Сова", Images.Owl);
            objects.Add("Курица", Images.Chicken);
            objects.Add("Птица", Images.Bird);
            // Создание рамки
            frame = new Frame(new Foundation(Brushes.Blue, 0.2),
                new Edge(Brushes.Red, new Thickness(1), 1),
                new Inscription(14, Brushes.White, new Thickness(5, 3, 0, 0)));
            
        }
        public void TimerAction(object sender, EventArgs e)
        {
            entityController.UpdateEntities(ref canvas, 5);
            trackerController.DetectField(canvas, ref dataField, objects, frame, true, true, true);
        }
    }
}
