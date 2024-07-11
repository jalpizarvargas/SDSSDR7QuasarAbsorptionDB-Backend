namespace QuasarWebAppAPI.Models
{
    public class ResponseHandler
    {

        //Creates an API Response for an Exception
        public static ApiResponse GetExceptionResponse(Exception ex)
        {
            ApiResponse response = new ApiResponse();
            response.Code = "1";
            response.ResponseData = ex.Message;
            return response;

        }

        //Creates an API Response for an API Request 
        public static ApiResponse GetAppResponse(ResponseType type, object? data) 
        {
            ApiResponse response;

            response = new ApiResponse { ResponseData = data };

            switch (type)
            {
                //Requested Data Exists
                case ResponseType.Success:
                    response.Code = "0";
                    response.Message = "Success";
                    break;
                //Requested Data Doesn't Exist
                case ResponseType.NotFound:
                    response.Code = "2";
                    response.Message = "No Entry Found";
                    break;
            }

            return response;
        }

    }
}
