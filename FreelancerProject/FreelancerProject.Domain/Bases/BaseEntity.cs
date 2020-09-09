using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.Domain.Bases
{
    public interface IBaseEntity<T> : IEntity
    {
        //Burani ozumuze gore deyishiklik ederik 
         T Id { get; set; }
    }
}
