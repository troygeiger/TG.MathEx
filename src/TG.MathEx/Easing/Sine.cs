using System;
using System.Collections.Generic;
using System.Text;

// These easing functions are based on the Java implementation at https://github.com/jesusgollonet/processing-penner-easing 
namespace TG.MathEx.Easing
{
    /// <summary>
    /// Provides sine easing functions
    /// </summary>
    public static class Sine
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
            return -change * (float)Math.Cos(time / duration * (Math.PI / 2)) + change + begin;
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
            return change * (float)Math.Sin(time / duration * (Math.PI / 2)) + begin;
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
            return -change / 2 * ((float)Math.Cos(Math.PI * time / duration) - 1) + begin;
        }

    }
}
