using CommonUtilities.Utility;
using System;
using System.Runtime.InteropServices;

namespace Integreon_v1.Helpers
{
    public static class HasPattern
    {
        public static void CheckGet<T>(ref bool hasFlag, ref T value, Func<T> getterFunc)
        {
            hasFlag = false;
            try
            {
                value = getterFunc();
                hasFlag = true;
            }
            catch (ArgumentException ex)
            {
                if (!ex.Message.Contains("The specified") && !ex.Message.Contains("is not valid for"))
                    throw;
            }
            catch (COMException ex)
            {
                if ( ex.Message != "This property is not valid for the current chart type.")
                    throw;
            }
        }
        public static void CheckGet<T>(ref T value, Func<T> getterFunc, Logger log)
        {
            //hasFlag = false;
            try
            {
                value = getterFunc();
                //hasFlag = true;
            }
            catch (ArgumentException ex)
            {
                log.Error(ex.Message);
                 
            }
            catch (COMException ex)
            {
                log.Error(ex.Message);

            }
        }
    }
}
