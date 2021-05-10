using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake_Sencenbaugh_Final
{
    class Dog
    {
        private string dogName, ownerName, address, notes;
        private float walkTime;
        public Dog(string dName, string oName, string aAddress, string aNote, float time)
        {
            DogName = dName;
            OwnerName = oName;
            Address = aAddress;
            Notes = aNote;
            WalkTime = time;
        }

        public string DogName { get => dogName; set => dogName = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string Address { get => address; set => address = value; }
        public string Notes { get => notes; set => notes = value; }
        public float WalkTime { get => walkTime; set => walkTime = value; }
    }
}
