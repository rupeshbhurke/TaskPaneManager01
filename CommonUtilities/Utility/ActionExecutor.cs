using CommonUtilities.Extensions;
using System;

namespace CommonUtilities.Utility
{

    /// <summary>
    /// The action executor.
    /// </summary>
    public static class ActionExecutor
    {
        /// <summary>
        /// The execute action with 1 possible exception
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="TException1">
        /// Exception Type 1
        /// </typeparam>
        /// <returns>
        /// The <see cref="BooleanResult"/>.
        /// </returns>
        public static BooleanResult ExecuteAction<TException1>(Action action) where TException1 : Exception
        {
            try
            {
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        /// <summary>
        /// The execute action with 2 possible exceptions.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="TException1">Exception Type 1
        /// </typeparam>
        /// <typeparam name="TException2">Exception Type 2
        /// </typeparam>
        /// <returns>
        /// The <see cref="BooleanResult"/>.
        /// </returns>
        public static BooleanResult ExecuteAction<TException1, TException2>(Action action)
            where TException1 : Exception
            where TException2 : Exception
        {
            try
            {
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        /// <summary>
        /// The execute action with 3 possible exceptions.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="TException1">Exception Type 1
        /// </typeparam>
        /// <typeparam name="TException2">Exception Type 2
        /// </typeparam>
        /// <typeparam name="TException3">Exception Type 3
        /// </typeparam>
        /// <returns>
        /// The <see cref="BooleanResult"/>.
        /// </returns>
        public static BooleanResult ExecuteAction<TException1, TException2, TException3>(Action action)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
        {
            try
            {
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        /// <summary>
        /// The execute action.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="TException1"> Exception Type 1
        /// </typeparam>
        /// <typeparam name="TException2"> Exception Type 2
        /// </typeparam>
        /// <typeparam name="TException3"> Exception Type 3
        /// </typeparam>
        /// <typeparam name="TException4"> Exception Type 4
        /// </typeparam>
        /// <returns>
        /// The <see cref="BooleanResult"/>.
        /// </returns>
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4>(Action action)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
        {
            try
            {
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        /// <summary>
        /// The execute action.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="TException1"> Exception Type 1
        /// </typeparam>
        /// <typeparam name="TException2"> Exception Type 2
        /// </typeparam>
        /// <typeparam name="TException3"> Exception Type 3
        /// </typeparam>
        /// <typeparam name="TException4"> Exception Type 4
        /// </typeparam>
        /// <typeparam name="TException5"> Exception Type 5
        /// </typeparam>
        /// <returns>
        /// The <see cref="BooleanResult"/>.
        /// </returns>
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5>(Action action)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
        {
            try
            {
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        /// <summary>
        /// The execute action.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="TException1"> Exception Type 1
        /// </typeparam>
        /// <typeparam name="TException2"> Exception Type 2
        /// </typeparam>
        /// <typeparam name="TException3"> Exception Type 3
        /// </typeparam>
        /// <typeparam name="TException4"> Exception Type 4
        /// </typeparam>
        /// <typeparam name="TException5"> Exception Type 5
        /// </typeparam>
        /// <typeparam name="TException6"> Exception Type 6
        /// </typeparam>
        /// <returns>
        /// The <see cref="BooleanResult"/>.
        /// </returns>
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6>(Action action)
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            where TException5 : Exception
            where TException6 : Exception
        {
            try
            {
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Seven exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Eight exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Nine exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Ten exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Eleven exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Twelve exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Thirteen exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Fourteen exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException14 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Fifteen exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException14 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException15 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }

        // Sixteen exception types
        public static BooleanResult ExecuteAction<TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(Action action)
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
                action();
                return BooleanResult.DefaultResult;
            }
            catch (TException1 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException2 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException3 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException4 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException5 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException6 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException7 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException8 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException9 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException10 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException11 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException12 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException13 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException14 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException15 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
            catch (TException16 ex)
            {
                return BooleanResult.FailResult(ex.GetExtFullMessage());
            }
        }
    }
}
