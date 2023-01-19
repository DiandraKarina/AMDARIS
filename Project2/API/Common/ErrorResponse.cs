﻿namespace API.Common
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Phrase { get; set; }
        public List<string> Errors { get; } = new List<string>();
        public DateTime Timestamp { get; set; }
    }
}
