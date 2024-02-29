namespace PatternPrototype
{
    class Mammal : Animal, IMyCloneable<Mammal>
    {
        public int Age { get; set; }

        public new Mammal Clone()
        {
            return new Mammal { Species = this.Species, Age = this.Age };
        }
    }
}
