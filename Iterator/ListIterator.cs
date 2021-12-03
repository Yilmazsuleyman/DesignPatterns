namespace Iterator
{
    public class ListIterator : Iterator
    {
        private ADKDepartmani adk = new ADKDepartmani();
        private int index = 0;
        public object getItem()
        {
            Calisan c = adk.GetCalisanlar()[index];
            ++index;
            return c;
        }

        public bool next()
        {
            if (index < adk.GetCalisanlar().Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
