using System;

namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModels
    {
        public string RequestId { get; set; }
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
