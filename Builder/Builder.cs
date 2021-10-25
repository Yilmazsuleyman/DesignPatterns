namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildPart(string parca_ismi);
        public abstract Product GetProduct();
    }
}
