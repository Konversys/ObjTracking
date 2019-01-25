using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamTracker.ObjectsPack
{
    /// <summary>
    /// Шаблон
    /// </summary>
    public class Pattern
    {
        /// <summary>
        /// Массив байт для сравнения
        /// </summary>
        public byte[] Template { get; private set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; private set; }
        public Pattern(string title, byte[] template)
        {
            Template = template;
            Title = title;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
    }
}
