// These easing functions are based on the Java implementation at https://github.com/jesusgollonet/processing-penner-easing 
namespace TG.MathEx.Easing
{
    /// <summary>
    /// Provides bounce easing functions
    /// </summary>
    public static class Bounce
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
            return change - EaseOut(duration - time, 0, change, duration) + begin;
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
            if ((time /= duration) < (1 / 2.75f))
            {
                return change * (7.5625f * time * time) + begin;
            }
            else if (time < (2 / 2.75f))
            {
                return change * (7.5625f * (time -= (1.5f / 2.75f)) * time + .75f) + begin;
            }
            else if (time < (2.5 / 2.75))
            {
                return change * (7.5625f * (time -= (2.25f / 2.75f)) * time + .9375f) + begin;
            }
            else
            {
                return change * (7.5625f * (time -= (2.625f / 2.75f)) * time + .984375f) + begin;
            }
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
            if (time < duration / 2) return EaseIn(time * 2, 0, change, duration) * .5f + begin;
            else return EaseOut(time * 2 - duration, 0, change, duration) * .5f + change * .5f + begin;
        }
    }
}
