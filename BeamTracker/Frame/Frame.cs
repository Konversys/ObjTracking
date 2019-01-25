using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BeamTracker.FrameBase
{
    /// <summary>
    /// Визуальное выделение найденых элементов
    /// Фасад
    /// </summary>
    public class Frame
    {
        public static void ResetCount()
        {
            count = 0;
        }
        static int count = 0;
        public int X { get; private set; }
        public int Y { get; private set; }
        public int ID { get; private set; }
        public Frame(Foundation foundation, Edge edge, Inscription inscription)
        {
            Foundation = foundation;
            Edge = edge;
            Inscription = inscription;
            ID = count++;
        }
        // Фон
        internal Foundation Foundation { get; set; }
        // Края
        internal Edge Edge { get; set; }
        // Надпись
        internal Inscription Inscription { get; set; }
        /// <summary>
        /// Получить рамку
        /// </summary>
        /// <param name="isFoudation">Фон</param>
        /// <param name="isEdge">Рамка</param>
        /// <param name="isInscription">Текст</param>
        /// <returns></returns>
        internal Canvas GetFrame(Thickness thickness, bool isFoudation, bool isEdge, bool isInscription, double size)
        {
            Canvas canvas = new Canvas() { Margin = thickness };
            if (isFoudation)
                canvas.Children.Add(Foundation.GetObject(size));
            if (isEdge)
                canvas.Children.Add(Edge.GetObject(size));
            if (isInscription)
                canvas.Children.Add(Inscription.GetObject());
            return canvas;
        }
        internal void SetPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
