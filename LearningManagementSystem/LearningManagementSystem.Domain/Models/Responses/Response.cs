﻿namespace LearningManagementSystem.Domain.Models.Responses
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public Error? Error { get; set; }

        public static Response<T> GetSuccess(T data)
        {
            ArgumentNullException.ThrowIfNull(data);
            return new Response<T>()
            {
                Data = data
            };
        }
        public static Response<T> GetError(ErrorCode errorCode, string errorMessage)
        {
            return new Response<T>()
            {
                Error = new Error()
                {
                    ErrorCode = errorCode,
                    ErrorMessage = errorMessage
                }
            };
        }
    }

    public class Response
    {
        public bool IsSuccessful { get; set; }
        public string? Error { get; set; }
    }
}
