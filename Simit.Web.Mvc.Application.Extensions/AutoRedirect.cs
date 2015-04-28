namespace Simit.Web.Mvc.Application.Extensions
{
    #region Using Directives

    using System;

    #endregion Using Directives

    public sealed class AutoRedirect
    {
        #region Public Properties

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string URL { get; private set; }

        public bool IsExternalURL
        {
            get { return this.URL.ToLower().StartsWith("http"); }
        }

        #endregion Public Properties

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRedirect"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <exception cref="ArgumentNullException">url</exception>
        public AutoRedirect(string url)
        {
            if (string.IsNullOrEmpty(url)) 
                throw new ArgumentNullException("url");

            this.URL = url;
        }

        #endregion Public Constructors
    }
}