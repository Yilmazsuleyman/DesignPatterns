using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        public static void Construct(Builder builder, string[] pieces)
        {
            foreach (string p in pieces)
            {
                builder.BuildPart(p);
            }
        }
    }
    class ConcreteBuilder1 : Builder
    {
        private Product m_Product = new Product();

        public override void BuildPart(string parca_ismi)
        {
            m_Product.Add(parca_ismi);
        }
        public override Product GetProduct()
        {
            return m_Product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product m_Product = new Product();

        public override void BuildPart(string parca_ismi)
        {
            m_Product.Add(parca_ismi);
        }
        public override Product GetProduct()
        {
            return m_Product;
        }
    }

   
}
