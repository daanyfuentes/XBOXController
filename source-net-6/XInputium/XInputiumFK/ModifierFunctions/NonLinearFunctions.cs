using System;
using XBOXController;

namespace XInputium.ModifierFunctions;

/// <summary>
/// Provides static members that allow the creation of customized 
/// modifier functions that can be used to turn a normalized 
/// linear value into a non-linear one.
/// </summary>
/// <seealso cref="ModifierFunction"/>
public static class NonLinearFunctions
{


    #region Properties

    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// provided value without any modification.
    /// </summary>
    public static ModifierFunction Linear { get; }
        = value => value;


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in quadratic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseIn(float)"/>
    public static ModifierFunction QuadraticEaseIn { get; }
        = value => value * Math.Abs(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out quadratic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseOut(float)"/>
    public static ModifierFunction QuadraticEaseOut { get; }
        = PowerEaseOut(2f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out quadratic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseInOut(float)"/>
    public static ModifierFunction QuadraticEaseInOut { get; }
        = PowerEaseInOut(2f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in cubic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseIn(float)"/>
    public static ModifierFunction CubicEaseIn { get; }
        = PowerEaseIn(3f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out cubic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseOut(float)"/>
    public static ModifierFunction CubicEaseOut { get; }
        = PowerEaseOut(3f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out cubic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseInOut(float)"/>
    public static ModifierFunction CubicEaseInOut { get; }
        = PowerEaseInOut(3f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in quartic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseIn(float)"/>
    public static ModifierFunction QuarticEaseIn { get; }
        = PowerEaseIn(4f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out quartic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseOut(float)"/>
    public static ModifierFunction QuarticEaseOut { get; }
        = PowerEaseOut(4f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out quartic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseInOut(float)"/>
    public static ModifierFunction QuarticEaseInOut { get; }
        = PowerEaseInOut(4f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in quintic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseIn(float)"/>
    public static ModifierFunction QuinticEaseIn { get; }
        = PowerEaseIn(5f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out quintic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseOut(float)"/>
    public static ModifierFunction QuinticEaseOut { get; }
        = PowerEaseOut(5f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out quintic result of the provided value.
    /// </summary>
    /// <seealso cref="PowerEaseInOut(float)"/>
    public static ModifierFunction QuinticEaseInOut { get; }
        = PowerEaseInOut(5f);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in sine of the provided value.
    /// </summary>
    /// <seealso cref="SineEaseOut"/>
    /// <seealso cref="SineEaseInOut"/>
    public static ModifierFunction SineEaseIn { get; }
        = value => (float)Math.Abs(
            Math.Sin((value - 1f) * Math.PI / 2f) + 1f
            ).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out sine of the provided value.
    /// </summary>
    /// <seealso cref="SineEaseIn"/>
    /// <seealso cref="SineEaseInOut"/>
    public static ModifierFunction SineEaseOut { get; }
        = value => (float)Math.Abs(
            Math.Sin(value * Math.PI / 2f)
            ).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out sine of the provided value.
    /// </summary>
    /// <seealso cref="SineEaseIn"/>
    /// <seealso cref="SineEaseOut"/>
    public static ModifierFunction SineEaseInOut { get; }
        = value => (float)Math.Abs(
            0.5f * (1f - Math.Cos(value * Math.PI))
            ).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in circular result of the provided value.
    /// </summary>
    /// <seealso cref="CircularEaseOut"/>
    /// <seealso cref="CircularEaseInOut"/>
    public static ModifierFunction CircularEaseIn { get; }
        = value => (float)Math.Abs(1f - Math.Sqrt(1f - (Math.Abs(value) * Math.Abs(value)))).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out circular result of the provided value.
    /// </summary>
    /// <seealso cref="CircularEaseIn"/>
    /// <seealso cref="CircularEaseInOut"/>
    public static ModifierFunction CircularEaseOut { get; }
        = value => (float)Math.Abs(
            Math.Sqrt((2f - Math.Abs(value)) * Math.Abs(value))
            ).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out circular result of the provided value.
    /// </summary>
    /// <seealso cref="CircularEaseIn"/>
    /// <seealso cref="CircularEaseOut"/>
    public static ModifierFunction CircularEaseInOut { get; }
        = value =>
        {
            value = InputMath.Clamp11(value);
            return (float)(Math.Abs(value) < 0.5f
                ? Math.Abs(
                    0.5f * (1f - Math.Sqrt(1f - 4f * (Math.Abs(value) * Math.Abs(value))))
                    ).CopySign(value)
                : Math.Abs(
                    0.5f * (Math.Sqrt(-((2 * Math.Abs(value)) - 3f) * ((2f * Math.Abs(value)) - 1f)) + 1f)
                    ).CopySign(value));
        };


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in exponential result of the provided value.
    /// </summary>
    /// <seealso cref="ExponentialEaseOut"/>
    /// <seealso cref="ExponentialEaseInOut"/>
    public static ModifierFunction ExponentialEaseIn { get; }
        = value => (float)Math.Abs(
            value == 0f ? 0f : Math.Pow(2f, 10f * (Math.Abs(value) - 1f))
            ).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-out exponential result of the provided value.
    /// </summary>
    /// <seealso cref="ExponentialEaseIn"/>
    /// <seealso cref="ExponentialEaseInOut"/>
    public static ModifierFunction ExponentialEaseOut { get; }
        = value => (float)Math.Abs(
            InputMath.Clamp01(Math.Abs(value)) == 1f ? 1f
            : 1f - Math.Pow(2f, -10f * Math.Abs(value))
            ).CopySign(value);


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// eased-in-out exponential result of the provided value.
    /// </summary>
    /// <seealso cref="ExponentialEaseIn"/>
    /// <seealso cref="ExponentialEaseOut"/>
    public static ModifierFunction ExponentialEaseInOut { get; }
        = value =>
        {
            value = InputMath.Clamp11(value);
            if (value == 0f)
                return 0f;
            if (Math.Abs(value) == 1f)
                return value;
            if (Math.Abs(value) < 0.5f)
                return (float)Math.Abs(
                    0.5f * Math.Pow(2f, (20f * Math.Abs(value)) - 10f)
                    ).CopySign(value);
            else
                return (float)Math.Abs(
                    -0.5f * Math.Pow(2f, (-20f * Math.Abs(value)) + 10f) + 1f
                    ).CopySign(value);
        };


    /// <summary>
    /// Gets a <see cref="ModifierFunction"/> that returns the 
    /// Bézier of the provided value.
    /// </summary>
    public static ModifierFunction Bezier { get; }
        = value => (float)((double)(Math.Abs(value)
            * Math.Abs(value)
            * (3.0f - 2.0f * Math.Abs(value)))).CopySign(value);

    #endregion Properties


    #region Methods

    /// <summary>
    /// Creates a new <see cref="ModifierFunction"/> that eases-in 
    /// a value using the specified power.
    /// </summary>
    /// <param name="power">Power to ease the value.</param>
    /// <returns>The new created <see cref="ModifierFunction"/> 
    /// delegate instance.</returns>
    /// <exception cref="ArgumentException"><paramref name="power"/> 
    /// is <see cref="float.NaN"/>.</exception>
    public static ModifierFunction PowerEaseIn(float power)
    {
        if (float.IsNaN(power))
            throw new ArgumentException(
                $"'{float.NaN}' is not a valid value for " +
                $"'{nameof(power)}' parameter.",
                nameof(power));

        return value => (float)Math.Pow(Math.Abs(value), power).CopySign(value);
    }


    /// <summary>
    /// Creates a new <see cref="ModifierFunction"/> that eases-out 
    /// a value using the specified power.
    /// </summary>
    /// <param name="power">Power to ease the value.</param>
    /// <returns>The new created <see cref="ModifierFunction"/> 
    /// delegate instance.</returns>
    /// <exception cref="ArgumentException"><paramref name="power"/> 
    /// is <see cref="float.NaN"/>.</exception>
    public static ModifierFunction PowerEaseOut(float power)
    {
        if (float.IsNaN(power))
            throw new ArgumentException(
                $"'{float.NaN}' is not a valid value for " +
                $"'{nameof(power)}' parameter.",
                nameof(power));

        return value =>
        {
            float v = Math.Abs(value);
            // Flip(Flip(v)^power), where Flip(v) = 1 - v.
            v = (float)(1f - Math.Pow(1f - v, power));
            return (float)((double)v).CopySign(value);
        };
    }


    /// <summary>
    /// Creates a new <see cref="ModifierFunction"/> that eases-in-out 
    /// a value using the specified power.
    /// </summary>
    /// <param name="power">Power to ease the value.</param>
    /// <returns>The new created <see cref="ModifierFunction"/> 
    /// delegate instance.</returns>
    /// <exception cref="ArgumentException"><paramref name="power"/> 
    /// is <see cref="float.NaN"/>.</exception>
    public static ModifierFunction PowerEaseInOut(float power)
    {
        if (float.IsNaN(power))
            throw new ArgumentException(
                $"'{float.NaN}' is not a valid value for " +
                $"'{nameof(power)}' parameter.",
                nameof(power));

        return value =>
        {
            float v = Math.Abs(value);
            float easeIn = (float)Math.Pow(v * 2f, power);
            float easeOut = (float)(2f - Math.Pow(2f - v * 2f, power));
            v = v < 0.5f ? easeIn * 0.5f : easeOut * 0.5f;
            return (float)((double)v).CopySign(value);
        };
    }

    #endregion Methods


}
