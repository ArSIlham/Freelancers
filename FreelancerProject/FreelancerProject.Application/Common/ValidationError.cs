using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Application.Common
{
    public class ValidationError
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public ValidationError(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
