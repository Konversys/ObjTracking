using BeamTracker.FrameBase;
using BeamTracker.Objects;
using BeamTracker.ObjectsPack;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Frame = BeamTracker.FrameBase.Frame;

namespace BeamTracker
{
    public class TrackerController
    {
        public void DetectField(Canvas source, ref Canvas field, EntityTemplates objects, Frame frame, bool isEdge, bool isTitle, bool isBg)
        {
            Detector detector = new Detector(source);
            detector.Search();
            List<Entity> images = detector.GetImages();

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
        }
    }
}
