namespace PatternPrototype
{
    class Dog : Mammal, IMyCloneable<Dog>
    {
        public string Breed { get; set; }

        public new Dog Clone()
        {
            return new Dog { Species = this.Species, Age = this.Age, Breed = this.Breed };
        }
    }
}
