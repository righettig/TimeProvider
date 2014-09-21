using System;

namespace rg.Time
{
    /// <summary>
    /// Provides methods to deal with time.
    /// </summary>
    public static class TimeProvider
    {
        #region Public properties

        /// <summary>
        /// Gets a <see cref="T:System.DateTime"/> object that is set to the current date and time on this computer, 
        /// expressed as the local time.
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date and time.
        /// </returns>
        public static DateTime Now
        {
            get { return _current.Now; }
        }

        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, 
        /// expressed as the Coordinated Universal Time (UTC).
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date and time.
        /// </returns>
        public static DateTime UtcNow
        {
            get { return _current.UtcNow; }
        }

        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date on this computer.
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date.
        /// </returns>
        public static DateTime Today
        {
            get { return _current.Today; }
        }

        #endregion

        #region Internal state (for unit testing)

        /// <summary>
        /// Sets the current time provider.
        /// </summary>
        /// <value>
        /// The time provider.
        /// </value>
        /// <exception cref="System.ArgumentNullException">value</exception>
        internal static ITimeProvider Current
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _current = value;
            }
        }

        /// <summary>
        /// Resets the default time provider.
        /// </summary>
        internal static void ResetToDefault()
        {
            _current = s_default;
        }

        #endregion

        #region Singleton pattern

        private static readonly ITimeProvider s_default = new DefaultTimeProvider();

        private static ITimeProvider _current = s_default;

        #endregion
    }
}
