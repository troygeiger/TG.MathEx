using System;

// These easing functions are based on the Java implementation at https://github.com/jesusgollonet/processing-penner-easing 
namespace TG.MathEx.Easing
{
    public static class Elastic
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
            if (time == 0) return begin; if ((time /= duration) == 1) return begin + change;
            float p = duration * .3f;
            float a = change;
            float s = p / 4;
            return -(a * (float)Math.Pow(2, 10 * (time -= 1)) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p)) + begin;
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <param name="a">I'm not sure what this parameter does.</param>
        /// <param name="p">I'm not sure what this parameter does.</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseIn(float time, float begin, float change, float duration, float a, float p)
        {
            float s;
            if (time == 0) return begin; if ((time /= duration) == 1) return begin + change;
            if (a < Math.Abs(change)) { a = change; s = p / 4; }
            else { s = p / (2 * (float)Math.PI) * (float)Math.Asin(change / a); }
            return -(a * (float)Math.Pow(2, 10 * (time -= 1)) * (float)Math.Sin((time * duration - s) * (2 * Math.PI) / p)) + begin;
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
            if (time == 0) return begin; if ((time /= duration) == 1) return begin + change;
            float p = duration * .3f;
            float a = change;
            float s = p / 4;
            return (a * (float)Math.Pow(2, -10 * time) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p) + change + begin);
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <param name="p">I'm not sure what this parameter does.</param>
        /// <param name="a">I'm not sure what this parameter does.</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseOut(float time, float begin, float change, float duration, float a, float p)
        {
            float s;
            if (time == 0) return begin; if ((time /= duration) == 1) return begin + change;
            if (a < Math.Abs(change)) { a = change; s = p / 4; }
            else { s = p / (2 * (float)Math.PI) * (float)Math.Asin(change / a); }
            return (a * (float)Math.Pow(2, -10 * time) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p) + change + begin);
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
            if (time == 0) return begin; if ((time /= duration / 2) == 2) return begin + change;
            float p = duration * (.3f * 1.5f);
            float a = change;
            float s = p / 4;
            if (time < 1) return -.5f * (a * (float)Math.Pow(2, 10 * (time -= 1)) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p)) + begin;
            return a * (float)Math.Pow(2, -10 * (time -= 1)) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p) * .5f + change + begin;
        }

        /// <summary>
        /// Easing function
        /// </summary>
        /// <param name="time">The current time (or position) of the tween. This can be seconds or frames, steps, seconds, ms, whatever – as long as the unit is the same as is used for the total time.</param>
        /// <param name="begin">The beginning value of the property.</param>
        /// <param name="change">The change between the beginning and destination value of the property</param>
        /// <param name="duration">The total time of the tween</param>
        /// <param name="a">I'm not sure what this parameter does.</param>
        /// <param name="p">I'm not sure what this parameter does.</param>
        /// <returns>Returns the value between the begin and change based on the time and duration.</returns>
        public static float EaseInOut(float time, float begin, float change, float duration, float a, float p)
        {
            float s;
            if (time == 0) return begin; if ((time /= duration / 2) == 2) return begin + change;
            if (a < Math.Abs(change)) { a = change; s = p / 4; }
            else { s = p / (2 * (float)Math.PI) * (float)Math.Asin(change / a); }
            if (time < 1) return -.5f * (a * (float)Math.Pow(2, 10 * (time -= 1)) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p)) + begin;
            return a * (float)Math.Pow(2, -10 * (time -= 1)) * (float)Math.Sin((time * duration - s) * (2 * (float)Math.PI) / p) * .5f + change + begin;
        }
    }
}
