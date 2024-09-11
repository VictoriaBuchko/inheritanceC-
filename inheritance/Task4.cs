using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        private double Weight;
        public bool IsPredator { get; set; }

        public Animal(string name, double weight, bool isPredator)
        {
            Name = name;
            Weight = weight;
            IsPredator = isPredator;
        }
        public override bool Equals(object obj)
        {
            if (obj is Animal other)
            {
                return Name == other.Name && Weight == other.Weight && IsPredator == other.IsPredator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Weight.GetHashCode() ^ IsPredator.GetHashCode();
        }
        public double SetWeight
        {
            get { return Weight; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Weight cannot be less than or equal to zero.");
                }
                else
                {
                    Weight = value;
                }
            }
        }

        public virtual double CalculateFoodRequirement()
        {

            return Weight * 0.01;
        }

        public override string ToString()
        {
            return $"Animal: {Name}, Weight: {Weight} kg, Predator: {(IsPredator ? "Yes" : "No")}";
        }
    }

    public class Tiger : Animal
    {
        public string StripePattern { get; set; }

        public Tiger(string name, double weight, bool isPredator, string stripePattern)
            : base(name, weight, isPredator)
        {
            StripePattern = stripePattern;
        }
        public override bool Equals(object obj)
        {
            if (obj is Tiger other)
            {
                return base.Equals(obj) && StripePattern == other.StripePattern;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ StripePattern.GetHashCode();
        }
        public override double CalculateFoodRequirement()
        {
            return base.CalculateFoodRequirement() * 1.5; // 50% больше
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Stripe Pattern: {StripePattern}";
        }
    }

    public class Crocodile : Animal
    {
        private double Length;

        public Crocodile(string name, double weight, bool isPredator, double length)
            : base(name, weight, isPredator)
        {
            Length = length;
        }
        public override bool Equals(object obj)
        {
            if (obj is Crocodile other)
            {
                return base.Equals(obj) && Length == other.Length;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Length.GetHashCode();
        }

        public double SetLength
        {
            get { return Length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be less than or equal to zero.");
                }
                else
                {
                    Length = value;
                }
            }
        }

        public override double CalculateFoodRequirement()
        {
            return base.CalculateFoodRequirement() * 0.8; // 20% меньше
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Length: {Length} meters";
        }
    }

    public class Kangaroo : Animal
    {
        private int JumpDistance;

        public Kangaroo(string name, double weight, bool isPredator, int jumpDistance)
            : base(name, weight, isPredator)
        {
            JumpDistance = jumpDistance;
        }

        public override bool Equals(object obj)
        {
            if (obj is Kangaroo other)
            {
                return base.Equals(obj) && JumpDistance == other.JumpDistance;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ JumpDistance.GetHashCode();
        }
        public int SetJumpDistance
        {
            get { return JumpDistance; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Jump distance cannot be less than or equal to zero.");
                }
                else
                {
                    JumpDistance = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Jump Distance: {JumpDistance} meters";
        }
    }

}
