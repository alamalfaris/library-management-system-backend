using System.Net;
using System.Text.Json.Serialization;

namespace LibraryManagementSystemBackend.Models
{
    [JsonSerializable(typeof(ApiResponse<>), GenerationMode = JsonSourceGenerationMode.Metadata)]
    public class ApiResponse<T>
    {
        [JsonPropertyOrder(1)]
        public int StatusCode { get; set; }

        [JsonPropertyOrder(2)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Error { get; set; }

        [JsonPropertyOrder(3)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; set; }

        [JsonPropertyOrder(4)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Details { get; set; }

        [JsonPropertyOrder(5)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T? Data { get; set; }

        public static ApiResponse<T> SuccessResponse(T data)
        {
            return new ApiResponse<T>
            {
                StatusCode = StatusCodes.Status200OK,
                Data = data
            };
        }

        public static ApiResponse<T> FailureResponse(int statusCode, string error, string? message = null, List<string>? details = null)
        {
            return new ApiResponse<T>
            {
                StatusCode = statusCode,
                Error = error,
                Message = message,
                Details = details
            };
        }
    }
}
