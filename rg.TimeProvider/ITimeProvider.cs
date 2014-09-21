using System;

namespace rg.Time
{
    /// <summary>
    /// The interface for all time providers.
    /// </summary>
    public interface ITimeProvider
    {
        /// <summary>
        /// Gets a <see cref="T:System.DateTime"/> object that is set to the current date and time on this computer, 
        /// expressed as the local time.
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date and time.
        /// </returns>
        DateTime Now { get; }

        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, 
        /// expressed as the Coordinated Universal Time (UTC).
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date and time.
        /// </returns>
        DateTime UtcNow { get; }

        /// <summary>
        /// Gets a <see cref="T:System.DateTime" /> object that is set to the current date on this computer.
        /// </summary>
        /// 
        /// <returns>
        /// An object whose value is the current local date.
        /// </returns>
        DateTime Today { get; }
    }
}
