using System;
using System.Collections.Generic;
using Passive_Componets;

namespace PassiveComponentsView.Tools
{
    [Serializable]
    class ElementsProject
    {
        /// <summary>
        /// 
        /// </summary>
        private double _angularFreguency;

        /// <summary>
        /// 
        /// </summary>
        public double AngularFrequency
        {
            get { return _angularFreguency; }

            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentException(@"Ошибка.");
                }
                _angularFreguency = value;
            }
        }

        public List<IElement> Elements { get; set; }
        public string FileName { get; set; }

        public ElementsProject(double angularFreguency, string fileName, List<IElement> elements)
        {
            AngularFrequency = angularFreguency;
            Elements = elements;
            FileName = fileName;
        }

        public ElementsProject()
        {
        }
    }
}
