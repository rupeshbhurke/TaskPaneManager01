using CommonUtilities.Extensions;
using System;

namespace CommonUtilities.Utility
{

    public static class FunctionExecutor
    {
        // Single exception type
        public static BooleanResult<TRet> ExecuteFunction<TException1, TRet>(Func<TRet> function) where TException1 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Two exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Three exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Four exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Five exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Six exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Seven exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Eight exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Nine exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Ten exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Eleven exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Twelve exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Thirteen exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Fourteen exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException14 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Fifteen exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException14 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException15 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }

        // Sixteen exception types
        public static BooleanResult<TRet> ExecuteFunction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TRet>(Func<TRet> function)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
            where TException7 : Exception
            where TException8 : Exception
            where TException9 : Exception
            where TException10 : Exception
            where TException11 : Exception
            where TException12 : Exception
            where TException13 : Exception
            where TException14 : Exception
            where TException15 : Exception
            where TException16 : Exception
        {
            try
            {
                TRet result = function();
                return BooleanResult<TRet>.SuccessResult(result);
            }
            catch (TException1 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException14 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException15 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
            catch (TException16 ex)
            {
                return BooleanResult<TRet>.FailResult(ex.GetExtFullMessage());
            }
        }
    }
}
