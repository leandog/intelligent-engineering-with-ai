namespace DurationConverter
{
    /// <summary>
    /// Provides methods to convert time strings into seconds.
    /// </summary>
    public static class DurationConverter
    {
        private const string Millisecond = "ms";
        private const string Second = "sec";
        private const string Minute = "min";
        private const string Hour = "hr";

        /// <summary>
        /// Converts a time string into seconds.
        /// </summary>
        /// <param name="time">The time string to convert.</param>
        /// <returns>The total time in seconds.</returns>
        public static double ConvertToSeconds(string time)
        {
            if (string.IsNullOrEmpty(time))
                return 0.0;

            var timeComponents = time.Split(' ');

            return timeComponents
                .Select((value, index) => (value, index))
                .Where(tuple => tuple.index % 2 == 0 && tuple.index + 1 < timeComponents.Length)
                .Where(tuple => int.TryParse(tuple.value, out _))
                .Sum(tuple =>
                    ConvertUnitToSeconds(int.Parse(tuple.value), timeComponents[tuple.index + 1])
                );
        }

        /// <summary>
        /// Converts a unit of time to seconds.
        /// </summary>
        /// <param name="amount">The amount of the time unit.</param>
        /// <param name="unit">The unit of time (e.g., ms, sec, min, hr).</param>
        /// <returns>The equivalent time in seconds.</returns>
        private static double ConvertUnitToSeconds(int amount, string unit)
        {
            return unit switch
            {
                Millisecond => amount * 0.001,
                Second => amount * 1.0,
                Minute => amount * 60.0,
                Hour => amount * 3600.0,
                _ => 0.0,
            };
        }
    }
}
