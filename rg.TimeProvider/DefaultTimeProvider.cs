using System;

namespace rg.Time
{
    /// <summary>
    /// The default time provider.
    /// <remarks>A thin wrapper around System.DateTime.</remarks>
    /// </summary>
    internal sealed class DefaultTimeProvider : ITimeProvider
    {
        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, 
        /// expressed as the local time.
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date and time.
        /// </returns>
        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, 
        /// expressed as the Coordinated Universal Time (UTC).
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date and time.
        /// </returns>
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }

        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date on this computer.
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date.
        /// </returns>
        public DateTime Today
        {
            get { return DateTime.Today; }
        }
    }
}
