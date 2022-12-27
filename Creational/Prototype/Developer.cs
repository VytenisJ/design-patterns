namespace Prototype
{
    internal class Developer : IPrototype
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Seniority { get; set; }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name}, {Age} - {Seniority}";
        }
    }
}