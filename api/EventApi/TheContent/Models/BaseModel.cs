using System;
namespace TheContent.Models
{
    public abstract class BaseModel
    {
        public string Id { get; set; }

        protected BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
