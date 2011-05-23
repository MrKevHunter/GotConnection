﻿namespace GotConnection
{
    /// <summary>
    /// Static factory class to get access to the implentation of the connection required.
    /// </summary>
    public static class ConnectTo
    {
        /// <summary>
        /// Create an instance of ITwitter with specific options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>An instance of ITwitter</returns>
        public static ITwitter Twitter(object options)
        {
            return new Twitter(options);
        }

        //public static IBlogger Blogger(object options)
        //{
        //    return new Blogger(options);
        //}
    }
}
