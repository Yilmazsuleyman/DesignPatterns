using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        private List<string> m_Parts = new List<string>();

        public void Add(string part)
        {
            m_Parts.Add(part);
        }
        public override string ToString()
        {
            string a = "Ürüne ait parçalar: \n\r";

            foreach (string part in m_Parts)
            {
                a += part + "\n\r";
            }
            return a;
        }
    }
}
