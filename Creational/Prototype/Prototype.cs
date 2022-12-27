namespace Prototype
{
    internal abstract class Prototype
    {
        public virtual Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}