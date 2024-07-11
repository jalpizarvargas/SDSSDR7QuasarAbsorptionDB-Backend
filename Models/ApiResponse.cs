namespace QuasarWebAppAPI.Models
{
    public class ApiResponse
    {
        //Number code associated with the response
        public string Code { get; set; }

        //Message showing the status of the API Response
        public string Message { get; set; }

        //Raw Data of the API Request JSON or Files
        public object? ResponseData { get; set; }

    }

    //Enumarator listing the different messages that response can return 
    public enum ResponseType {
        Success,
        NotFound,
        Failed
    }

}
