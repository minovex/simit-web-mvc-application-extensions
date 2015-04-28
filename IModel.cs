namespace Simit.Web.Mvc.Application.Extensions
{
    #region Using Directives

    using Simit.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    #endregion Using Directives

    /// <summary>
    /// 
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Gets the alerts.
        /// </summary>
        /// <value>
        /// The alerts.
        /// </value>
        List<Alert> Alerts { get; }

        /// <summary>
        /// Gets or sets the redirect.
        /// </summary>
        /// <value>
        /// The redirect.
        /// </value>
        AutoRedirect Redirect { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        bool IsValid { get; }

        /// <summary>
        /// Gets or sets the message parameters.
        /// </summary>
        /// <value>
        /// The message parameters.
        /// </value>
        object MessageParameters { get; set; }

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        void AddMessage(Alert.Type type, string message);

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="alerts">The alerts.</param>
        void AddMessage(List<Alert> alerts);
    }
}