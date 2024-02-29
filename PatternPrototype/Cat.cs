namespace PatternPrototype
{
    class Cat : Mammal, IMyCloneable<Cat>
    {
        public string EyeColor { get; set; }

        public new Cat Clone()
        {
            return new Cat { Species = this.Species, Age = this.Age, EyeColor = this.EyeColor };
        }
    }
}
