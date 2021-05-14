using System;

namespace Example_ArraySegment.Entities
{
    public class DesignPatterns
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public GroupPatterns Group { get; set; }

        public DesignPatterns(string name, GroupPatterns group){
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Group = group;
        }
    }
}