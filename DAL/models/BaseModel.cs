using System;

namespace blog.models
{
    // Access modifiers [
    // Public: The entire globe
    // internal:  accessed within the container project
    // protected: private plus derived class 
    // private: local accessed  within the container element
    public class BaseModel
    {
        // to set state into class use one of [field - property - automatic property]
        /*public DateTime GetCreationDate()
        {
            return this.CreationDate;
        }

        public void SetCreation(DateTime newValue)
        {
            this.CreationDate = newValue;
        }*/

        // automatic Property
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public User Owner { get; set; }

        public virtual DateTime GetCreationDate()
        {
            Console.WriteLine("In original implementation");
            return DateTime.Now;
        }
    }
}