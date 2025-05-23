using System;

namespace CommonUtilities.Utility
{

    public class BooleanResultArgs : EventArgs
    {
        public BooleanResultArgs(BooleanResult result)
        {
            Result = result;
        }

        public BooleanResult Result { get; }
    }
}