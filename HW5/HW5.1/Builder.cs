using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._1
{
    internal class Builder : IDeveloper
    {
        public string Tool { get; set; }
        public Builder(string Tool)
        {
            this.Tool = Tool;
        }

        public void Create()
        {
            Console.WriteLine($"Builder create something with {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder destroy something with {Tool}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
