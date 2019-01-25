using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    /// <summary>
    /// Приведение канваса к списку.
    /// Адаптер
    /// </summary>
    class Detector
    {
        Canvas canvas;
        List<IEntity> objects;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="canvas">Исходное полотно</param>
        public Detector(Canvas canvas)
        {
            this.canvas = canvas;
            objects = new List<IEntity>();
        }
        /// <summary>
        /// Поиск объектов 
        /// </summary>
        public List<IEntity> Search()
        {
            objects.Clear();
            foreach (var item in canvas.Children.Cast<Canvas>())
            {
                objects.Add(new Entity(item));
            }
            return objects;
        }
        /// <summary>
        /// Получить список объектов
        /// </summary>
        /// <returns></returns>
        public List<IEntity> GetImages()
        {
            return objects;
        }
    }
}
