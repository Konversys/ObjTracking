using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Controls;

namespace BeamTracker
{
    public class TrackerController
    {
        public void DetectField(Canvas source, ref Canvas field, EntityTemplates objects, Frame frame, bool isEdge, bool isTitle, bool isBg)
        {
            var sw = new Stopwatch();
            sw.Start();
            Detector detector = new Detector(source);
            detector.Search();
            List<IEntity> images = detector.GetImages();

            Comparator comparator = new Comparator();

            field.Children.Clear();
            foreach (var item in images)
            {
                string title = comparator.TryDetect(objects, item.Image);
                if (title != null)
                {
                    frame.Inscription.SetTitle(title);
                    field.Children.Add(frame.GetFrame(item.Thickness, isBg, isEdge, isTitle, item.Size));
                }
            }
            sw.Stop();
            long f = sw.ElapsedMilliseconds;
        }
    }
}
