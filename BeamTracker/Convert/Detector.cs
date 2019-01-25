using BeamTracker.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    /// <summary>
    /// Приведение канваса к списку.
    /// Адаптер
    /// </summary>
    class Detector : IDetector
    {
        Canvas canvas;
        List<Entity> objects;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="canvas">Исходное полотно</param>
        public Detector(Canvas canvas)
        {
            this.canvas = canvas;
            objects = new List<Entity>();
        }
        /// <summary>
        /// Поиск объектов 
        /// </summary>
        public List<Entity> Search()
        {
            objects.Clear();
            foreach (var item in canvas.Children.Cast<Canvas>())
            {
                objects.Add(new Entity((BitmapImage)((ImageBrush)item.Background).ImageSource, item.Height ,item.Margin));
            }
            return objects;
        }
        /// <summary>
        /// Получить список объектов
        /// </summary>
        /// <returns></returns>
        public List<Entity> GetImages()
        {
            return objects;
        }
    }
}
