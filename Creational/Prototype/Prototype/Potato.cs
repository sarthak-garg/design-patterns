using System;

namespace Prototype
{
    /// <summary>
    /// Sample class implementing the ICloneable interface
    /// </summary>
    /// <returns></returns>
    class Potato : ICloneable
    {
        private string name;
        private AdditionalDetails details = new AdditionalDetails();

        public string Name { get { return name; } set { name = value; } }

        public AdditionalDetails Details { get { return details; } set { details = value; } }

        /// <summary>
        /// Implemented Clone() method from the ICloneable interface
        /// This implements deep copy instead of shallow copy
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Potato potato = this.MemberwiseClone() as Potato;
            potato.Details = new AdditionalDetails();
            potato.Details.OwnerName = this.Details.OwnerName;
            return potato;
        }
    }
}
