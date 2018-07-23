using System;



namespace StudentEnroll
{
    public class StudentModel
    {
        public StudentModel()
        {
        }

        public string Name
        {
            get;
            set;
        }
        public string Age
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string ImageUrl
        {
            get;
            set;
        }
        public string Bio
        {
            get;
            set;
        }
        public string Summary
        {
            get{
                return Age + "-" + Address;
            }
        }
    }
}
