namespace PatternPrototype
{
    class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string Species { get; set; }

        public Animal Clone()
        {
            return new Animal { Species = this.Species };
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}