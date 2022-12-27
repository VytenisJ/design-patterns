namespace Prototype
{
    internal class Manager : Prototype
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age} ({Salary}K)";
        }
    }
}