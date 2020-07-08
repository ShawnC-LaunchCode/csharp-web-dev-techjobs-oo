using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

       



        public Employer(string value) : this()
        {
            Value = value;
        }

        public Employer()
        {
            Id = nextId;
            nextId++;
        }


        public override string ToString()
        {
            return Value;
        }
        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


    }
}
