namespace TEST.UnitTestProject
{
    public class Customer
    {
        private string v1;
        private string v2;

        public Customer(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public string Name()
        {
            return v1 + v2;
        }
    }
}