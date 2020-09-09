using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Bases
{
    public abstract class BaseEntity<T> : IEntity
    {
        //Burani ozumuze gore deyishiklik ederik 
        public T Id { get; set; }
    }
}
