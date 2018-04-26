using NullGuard;

namespace FodyExample
{
    public class NullClass
    {
        public NullClass(string name, [AllowNull]string description = null)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }

        public string Description { get; }
    }
}
