using CommonUtilities.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace CommonUtilities.Helpers
{
    public static class DirectoryHelper
    {
        /// <summary>
        /// Enumerates the subdirectories in given directory path and calls callback for each such find.
        /// The process will continue if callback returns true else it will stop and return.
        /// 
        /// Returns false if process was cancelled by callback else true.
        /// </summary>
        /// <param name="dirPath">Path of directory to search</param>
        /// <param name="callBack">Callback method/delegate/lambda</param>
        public static bool EnumerateSubDirectories(string dirPath, Func<string, bool> callBack)
        {
            IEnumerable<string> subDirectories = Directory.EnumerateDirectories(dirPath);
            foreach (string subDirectory in subDirectories)
            {
                if (!callBack(subDirectory))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Enumerates the files in given directory path and calls callback for each such find.
        /// The process will continue if callback returns true else it will stop and return.
        /// 
        /// Returns false if process was cancelled by callback else true.
        /// </summary>
        /// <param name="dirPath">Path of directory to search</param>
        /// <param name="pattern">The pattern of filename to be searched</param>
        /// <param name="callBack">Callback method/delegate/lambda</param>
        public static bool EnumerateFiles(string dirPath, string pattern, Func<string, bool> callBack)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(dirPath, pattern);
            foreach (string file in files)
            {
                if (!callBack(file))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Enumerates the files in given directory path and calls callback for each such find.
        /// The process will continue if callback returns true else it will stop and return.
        /// 
        /// Returns false if process was cancelled by callback else true.
        /// </summary>
        /// <param name="dirPath">Path of directory to search</param>
        /// <param name="pattern">The pattern of filename to be searched</param>
        /// <param name="recursive">Search in subdirectories</param>
        /// <param name="callBack">Callback method/delegate/lambda</param>
        public static bool EnumerateFiles(string dirPath, string pattern, bool recursive, Func<string, bool> callBack)
        {
            if (!EnumerateFiles(dirPath, pattern, callBack))
                return false;
            if (recursive)
            {
                EnumerateSubDirectories(dirPath,
                    subDirPath => EnumerateFiles(subDirPath,
                        pattern, true, callBack));
            }
            return true;
        }

        public static bool IsValidPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                return false;

            // Check if the path is rooted
            if (!Path.IsPathRooted(path))
                return false;

            // Check for invalid path characters
            char[] invalidChars = Path.GetInvalidPathChars();
            return path.IndexOfAny(invalidChars) < 0;
        }

        public static BooleanResult CheckCreateDirectory(string path, bool eraseExistingContent = false)
        {
            try
            {
                if (eraseExistingContent && Directory.Exists(path))
                {
                    //string[] files = Directory.GetFiles(path);

                    //foreach (string file in files)
                    //{
                    //   File.Delete(file);
                    Directory.Delete(path, true);
                    //}

                }
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return BooleanResult.DefaultResult;
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle unauthorized access exceptions
                return BooleanResult.FailResult($"Unauthorized access: {ex.Message}");
            }
            catch (PathTooLongException ex)
            {
                // Handle path too long exceptions
                return BooleanResult.FailResult($"Path too long: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                // Handle directory not found exceptions
                return BooleanResult.FailResult($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                // Handle I/O exceptions
                return BooleanResult.FailResult($"I/O error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                return BooleanResult.FailResult($"An error occurred: {ex.Message}");
            }
        }

        public static BooleanResult CheckFileCopy(string sourcePath, string destinationPath)
        {
            try
            {
                // Check if source file exists
                if (!File.Exists(sourcePath))
                {
                    return BooleanResult.FailResult($"Source file '{sourcePath}' does not exist.");
                }

                // Perform the file copy operation
                File.Copy(sourcePath, destinationPath, true);

                // Return success result
                return BooleanResult.SuccessResult(string.Empty);
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle unauthorized access exceptions
                return BooleanResult.FailResult($"Unauthorized access: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found exceptions
                return BooleanResult.FailResult($"File not found: {ex.Message}");
            }
            catch (PathTooLongException ex)
            {
                // Handle path too long exceptions
                return BooleanResult.FailResult($"Path too long: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                // Handle directory not found exceptions
                return BooleanResult.FailResult($"Directory not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                // Handle I/O exceptions
                return BooleanResult.FailResult($"I/O error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                return BooleanResult.FailResult($"An error occurred: {ex.Message}");
            }
        }

        public static BooleanResult MakeTempPath(string sourcePath, string destinationFolder, string suffix, bool failIfSourceNotExists = true)
        {
            try
            {
                // Check if source file exists
                if (failIfSourceNotExists && !File.Exists(sourcePath))
                {
                    return BooleanResult.FailResult($"Source file '{sourcePath}' does not exist.");
                }

                // Generate temporary file name
                string fileName = Path.GetFileNameWithoutExtension(sourcePath) + suffix;
                string extension = Path.GetExtension(sourcePath);
                string datePath = DateTime.Now.ToString(@"HHmmss_ffffff");
                string newFileName = $"{fileName}_{datePath}{extension}";

                // Combine destination folder and new file name to create temporary file path
                string tempFilePath = Path.Combine(destinationFolder, newFileName);

                // Return success result with temporary file path
                return BooleanResult.SuccessResult(tempFilePath);
            }
            catch (ArgumentException ex)
            {
                // Handle invalid arguments exceptions
                return BooleanResult.FailResult($"Invalid argument: {ex.Message}");
            }
            catch (PathTooLongException ex)
            {
                // Handle path too long exceptions
                return BooleanResult.FailResult($"Path too long: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                return BooleanResult.FailResult($"An error occurred: {ex.Message}");
            }
        }
        public static BooleanResult MakeTempPath(string destinationFolder, string namePrefix)
        {
            try
            {
                // Generate temporary file name
                string extension = ".part.log";
                string datePath = DateTime.Now.ToString(@"HHmmss_ffffff");
                string newFileName = $"{namePrefix}_{datePath}{extension}";

                // Combine destination folder and new file name to create temporary file path
                string tempFilePath = Path.Combine(destinationFolder, newFileName);

                // Return success result with temporary file path
                return BooleanResult.SuccessResult(tempFilePath);
            }
            catch (ArgumentException ex)
            {
                // Handle invalid arguments exceptions
                return BooleanResult.FailResult($"Invalid argument: {ex.Message}");
            }
            catch (PathTooLongException ex)
            {
                // Handle path too long exceptions
                return BooleanResult.FailResult($"Path too long: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                return BooleanResult.FailResult($"An error occurred: {ex.Message}");
            }
        }

        public static BooleanResult ValidateFilePath(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return BooleanResult.FailResult("File path cannot be null or empty.");

            if (!File.Exists(filePath))
                return BooleanResult.FailResult("The specified file does not exist.");

            return BooleanResult.DefaultResult;
        }

    }
}
