// These easing functions are based on the Java implementation at https://github.com/jesusgollonet/processing-penner-easing 
namespace TG.MathEx.Easing
{
    /// <summary>
    /// Provides ease back functions
    /// </summary>
    public static class Back
    {
        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseIn(float time, float begin, float change, float duration)
        {
            float s = 1.70158f;
            return change * (time /= duration) * time * ((s + 1) * time - s) + begin;
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <param name="s">I'm not sure what this parameter does.</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseIn(float time, float begin, float change, float duration, float s)
        {
            return change * (time /= duration) * time * ((s + 1) * time - s) + begin;
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseOut(float time, float begin, float change, float duration)
        {
            return EaseOut(time, begin, change, duration, 1.70158f);
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <param name="s">I'm not what this parameter does.</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseOut(float time, float begin, float change, float duration, float s)
        {
            return change * ((time = time / duration - 1) * time * ((s + 1) * time + s) + 1) + begin;
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseInOut(float time, float begin, float change, float duration)
        {
            return EaseInOut(time, begin, change, duration, 1.70158f);
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <param name="s">I'm not sure what this parameter does.</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseInOut(float time, float begin, float change, float duration, float s)
        {
            if ((time /= duration / 2) < 1) return change / 2 * (time * time * (((s *= (1.525f)) + 1) * time - s)) + begin;
            return change / 2 * ((time -= 2) * time * (((s *= (1.525f)) + 1) * time + s) + 2) + begin;
        }
    }
}
