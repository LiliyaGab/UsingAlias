namespace PackageProject
{
    public class PackageClass
    {
        public string Field { get; }
        public int Prop { get; }

        public PackageClass(string field, int prop)
        {
            this.Field = field;
            this.Prop = prop;
        }
    }
}