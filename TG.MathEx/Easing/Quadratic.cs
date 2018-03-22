// These easing functions are based on the Java implementation at https://github.com/jesusgollonet/processing-penner-easing 
namespace TG.MathEx.Easing
{
    public static class Quadratic
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
            return change * (time /= duration) * time + begin;
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
            return -change * (time /= duration) * (time - 2) + begin;
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
            if ((time /= duration / 2) < 1) return change / 2 * time * time + begin;
            return -change / 2 * ((--time) * (time - 2) - 1) + begin;
        }

    }
}
