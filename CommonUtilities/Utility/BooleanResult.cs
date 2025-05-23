namespace CommonUtilities.Utility
{
    public class BooleanResult
    {
        public static readonly BooleanResult DefaultResult = new BooleanResult();

        public static BooleanResult SuccessResult(string message)
        {
            return new BooleanResult(true, message);
        }

        public static BooleanResult FailResult(string error)
        {
            return new BooleanResult(false, error);
        }

        private BooleanResult(bool success = true, string error = null)
        {
            Success = success;
            Message = error;
        }

        public bool Success { get; protected set; }
        public string Message { get; protected set; }
    }

    public class BooleanResult<T>
    {
        public static BooleanResult<T> SuccessResult(T result)
        {
            return new BooleanResult<T>
            {
                Success = true,
                Result = result
            };
        }

        public static BooleanResult<T> FailResult(string error)
        {
            return new BooleanResult<T>
            {
                Success = false,
                Message = error
            };
        }

        public BooleanResult<TRet> CopyFailureDetailsTo<TRet>()
        {
            return new BooleanResult<TRet>
            {
                Success = Success,
                Message = Message,
            };
        }

        public BooleanResult CopyFailureDetailsTo()
        {
            return BooleanResult.FailResult(Message);
        }

        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public T Result { get; protected set; }

    }
}
