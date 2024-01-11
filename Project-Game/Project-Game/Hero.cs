namespace Myspace
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int ResistanceToPhysical { get; set; }
        public int ResistanceToMagical { get; set; }
      

        public Hero(string Name, int Health, int AttackPower, int ResistanceToPhysical, int ResistanceToMagical)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.ResistanceToPhysical = ResistanceToPhysical;
            this.ResistanceToMagical = ResistanceToMagical;
         
        }

        
    }
}
