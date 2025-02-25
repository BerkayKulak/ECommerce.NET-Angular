﻿using System.Diagnostics;

namespace ECommerce.NET_Angular.API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            this.StatusCode = statusCode;

            this.Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

       
        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            string errorMessage = string.Empty;

            switch (statusCode)
            {
                case 400:
                    errorMessage = "A Bad request!, you have made";
                    break;
                case 401:
                    errorMessage = "UnAuthorized Error";
                    break;
                case 404:
                    errorMessage = "Resource Not Found";
                    break;
                case 500:
                    errorMessage = "Server Error";
                    break;
            }

            return errorMessage;
        }
    }
}
