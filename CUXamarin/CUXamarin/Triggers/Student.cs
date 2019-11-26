using System;
using System.Collections.Generic;
using System.Text;

namespace CUXamarin.Triggers
{
    public class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public bool IsApproved 
        { 
            get 
            {
                if (Score < 6)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
