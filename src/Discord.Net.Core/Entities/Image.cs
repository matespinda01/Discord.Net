﻿using System.IO;
namespace Discord
{
    /// <summary>
    /// An image that will be uploaded to Discord.
    /// </summary>
    public struct Image
    {
        public Stream Stream { get; }
        public ImageFormat Format { get; }

        /// <summary>
        /// Create the image with a Stream.
        /// </summary>
        /// <param name="stream">This must be some type of stream with the contents of a file in it.</param>
        public Image(Stream stream, ImageFormat format = ImageFormat.Jpeg)
        {
            Stream = stream;
            Format = format;
        }
#if FILESYSTEM
        /// <summary>
        /// Create the image from a file path.
        /// </summary>
        /// <remarks>
        /// This file path is NOT validated, and is passed directly into a <see cref="File.OpenRead(string)"/>
        /// </remarks>
        /// <param name="path">The path to the file.</param>
        public Image(string path, ImageFormat format = ImageFormat.Jpeg)
        {
            Stream = File.OpenRead(path);
            Format = format;
        }
#endif
    }
}
