using System.Collections;

namespace Iterator.NET
{
    class SampleContainer : IEnumerable
    {
        private SampleObject[] smp;

        public SampleObject[] Items
        {
            get
            {
                return smp;
            }
        }

        public SampleContainer()
        {
            smp = new SampleObject[2];
            smp[0] = new SampleObject() { Value = 10 };
            smp[1] = new SampleObject() { Value = 20 };
        }

        public IEnumerator GetEnumerator()
        {
            return new SampleIterator(this);
        }
    }
}
