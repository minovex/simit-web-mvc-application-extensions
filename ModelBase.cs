namespace Simit.Web.Mvc.Application.Extensions
{
    #region Using Directives

    using Simit.ComponentModel.DataAnnotations;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion Using Directives

    /// <summary>
    /// Model Base
    /// </summary>
    public class ModelBase : IModel
    {
        #region Public Properties

        /// <summary>
        /// Gets the alerts.
        /// </summary>
        /// <value>
        /// The alerts.
        /// </value>
        public List<Alert> Alerts { get; private set; }

        /// <summary>
        /// Gets or sets the redirect.
        /// </summary>
        /// <value>
        /// The redirect.
        /// </value>
        public AutoRedirect Redirect { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [invalid request].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [invalid request]; otherwise, <c>false</c>.
        /// </value>
        public bool InvalidRequest { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [success request].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [success request]; otherwise, <c>false</c>.
        /// </value>
        public bool SuccessRequest { get; set; }

        /// <summary>
        /// Gets or sets the message parameters.
        /// </summary>
        /// <value>
        /// The message parameters.
        /// </value>
        public object MessageParameters { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid
        {
            get { return this.Alerts.Count(c => c.AlertType != Alert.Type.Success && c.AlertType != Alert.Type.Info) == 0; }
        }

        #endregion Public Properties

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBase"/> class.
        /// </summary>
        protected ModelBase()
        {
            this.Alerts = new List<Alert>();
        }

        #endregion Protected Constructors

        #region Public Methods

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException">message</exception>
        public void AddMessage(Alert.Type type, string message)
        {
            if (message == null) 
                throw new ArgumentNullException("message");

            if (!this.Alerts.Any(c => c.AlertType == type && c.Meesage == message))
            {
                this.Alerts.Add(new Alert { AlertType = type, Meesage = message });
            }
        }

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="alerts">The alerts.</param>
        /// <exception cref="ArgumentNullException">alerts</exception>
        public void AddMessage(List<Alert> alerts)
        {
            if (alerts == null) 
                throw new ArgumentNullException("alerts");

            alerts.ForEach(c =>
            {
                this.AddMessage(c.AlertType, c.Meesage);
            });
        }

        #endregion Public Methods
    }
}