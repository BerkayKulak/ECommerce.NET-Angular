﻿namespace ECommerce.NET_Angular.API.Errors
{
    public class ApiException:ApiResponse
    {
        public ApiException(int statusCode, string message = null,string details =null) : base(statusCode, message)
        {
            this.Details = details;
        }

        public string Details { get; set; }
    }
}
