namespace QuasarWebAppAPI.Models
{
    public class ResponseHandler
    {

        public static ApiResponse GetExceptionResponse(Exception ex)
        {
            ApiResponse response = new ApiResponse();
            response.Code = "1";
            response.ResponseData = ex.Message;
            return response;

        }

        public static ApiResponse GetAppResponse(ResponseType type, object? data) 
        {

            ApiResponse response;

            response = new ApiResponse { ResponseData = data };

            switch (type)
            {
                case ResponseType.Success:
                    response.Code = "0";
                    response.Message = "Success";
                    break;
                case ResponseType.NotFound:
                    response.Code = "2";
                    response.Message = "No Entry Found";
                    break;
            }

            return response;
        }

    }
}
