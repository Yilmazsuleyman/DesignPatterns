namespace Iterator
{
    public class ArrayIterator : Iterator
    {
        private IKDepartmani ik = new IKDepartmani();
        private int index = 0;
        public object getItem()
        {
            Calisan c = ik.GetCalisanlar()[index];
            ++index;
            return c;
        }

        public bool next()
        {
            if (index < ik.GetCalisanlar().Length)
            {
                return true;
            }
            return false;
        }
    }
}
