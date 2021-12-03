using System.ComponentModel;

namespace Observer.NET
{
    public class CStock : INotifyPropertyChanged
    {
        private int m_Adet;
        private string m_Urun;
        public int Adet { get { return m_Adet; } set { m_Adet = value; OnChanged("Adet"); } }
        public string Urun { get { return m_Urun; } set { m_Urun = value; OnChanged("Adet"); } }

        public CStock(string urun, int adet)
        {
            m_Adet = adet;
            m_Urun = urun;
        }
        private void OnChanged(string prop_name)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop_name));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
