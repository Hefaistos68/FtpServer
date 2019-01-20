// <copyright file="FileSystemException.cs" company="40three GmbH">
// Copyright (c) 40three GmbH. All rights reserved.
// </copyright>

namespace FubarDev.FtpServer.FileSystem.Error
{
    /// <summary>
    /// Represents an error condition the underlying file system wants to communicate to the client.
    /// </summary>
    public abstract class FileSystemException : System.Exception
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="FileSystemException"/> class.
        /// </summary>
        public FileSystemException()
            : base()
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="FileSystemException"/> class.
        /// </summary>
        /// <param name="message">Error message</param>
        public FileSystemException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="FileSystemException"/> class.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">Underlying exception</param>
        public FileSystemException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Gets the FTP error code.
        /// </summary>
        public abstract int FtpErrorCode { get; }

        /// <summary>
        /// Gets a human-readable generic error description.
        /// </summary>
        public abstract string FtpErrorName { get; }
    }
}
