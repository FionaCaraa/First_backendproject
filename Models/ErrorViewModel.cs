using First_backend.Models.Entites;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.ComponentModel;

namespace First_backend.Models
{
    public class ErrorViewModel

    {
        public string RequestId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
  
        public bool ShowRequestId => string.IsNullOrEmpty(RequestId);
   
    }
    public class Category
    {
       
    }
   
    namespace First_backend.ViewModels
    {
        public class ErrorViewModel
        {
            public string RequestId { get; set; }
            public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

            // Ek özellikler
            public string ImageUrl { get; set; }
        }
    }

}






