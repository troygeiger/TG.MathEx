using System;

// These easing functions are based on the Java implementation at https://github.com/jesusgollonet/processing-penner-easing 
namespace TG.MathEx.Easing
{
    public static class Exponential
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
            return (time == 0) ? begin : change * (float)Math.Pow(2, 10 * (time / duration - 1)) + begin;
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
            return (time == duration) ? begin + change : change * (-(float)Math.Pow(2, -10 * time / duration) + 1) + begin;
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
            if (time == 0) return begin;
            if (time == duration) return begin + change;
            if ((time /= duration / 2) < 1) return change / 2 * (float)Math.Pow(2, 10 * (time - 1)) + begin;
            return change / 2 * (-(float)Math.Pow(2, -10 * --time) + 2) + begin;
        }

    }
}
