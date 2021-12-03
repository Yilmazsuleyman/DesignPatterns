using System.Collections;

namespace Iterator.NET
{
    class SampleIterator : IEnumerator
    {
        private int p = -1;
        private SampleContainer container;

        public SampleIterator(SampleContainer sc)
        {
            container = sc;
        }
        public object Current { get { return container.Items[p]; } }

        public bool MoveNext()
        {
            if (p < container.Items.Length-1)
            {
                ++p;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            p = 0;
        }
    }
}
