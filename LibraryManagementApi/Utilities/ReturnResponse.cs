namespace LibraryManagementApi.Utilities
{
    public class ReturnResponse<T> where T : class
    {
        public string message { get; set; }
        public bool error { get; set; }
        public T? data { get; set; }
        public int statusCode { get; set; } = StatusCodes.Status200OK;

        public ReturnResponse(T data, string messageSuccess = "Sucess", string messageFail = "Fail")
        {
            if (data == null)
            {
                message = messageFail;
                error = true;
            }
            else
            {
                message = messageSuccess;
                error = false;
                this.data = data;
            }
        }

        public ReturnResponse(T data, int statusCode, string message = "Sucess")
        {
            if (data == null)
            {
                error = true;
            }
            else
            {
                error = false;
                this.data = data;
            }
            this.statusCode = statusCode;
            this.message = message;

        }
    }
}
