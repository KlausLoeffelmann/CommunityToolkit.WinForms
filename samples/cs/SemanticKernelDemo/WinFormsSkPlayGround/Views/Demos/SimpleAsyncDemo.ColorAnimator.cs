namespace WinFormsSkPlayGround.Views;

public partial class SimpleAsyncDemo
{
    private class ColorAnimator
    {
        int _duration = 5000; // Duration of the color transition in milliseconds
        int _steps = 100; // Number of steps in the transition

        Color _startColor = Color.Blue;
        Color _endColor = Color.Red;

        int _stepDelay;
        int _i = 0;
        int _direction = 1;

        public ColorAnimator()
        {
            _stepDelay = _duration / _steps;
        }

        public static ColorAnimator Default { get; } = new ColorAnimator();

        public Color Trigger()
        {
            float ratio = (float)_i / _steps;
            int red = (int)(_startColor.R + (_endColor.R - _startColor.R) * ratio);
            int green = (int)(_startColor.G + (_endColor.G - _startColor.G) * ratio);
            int blue = (int)(_startColor.B + (_endColor.B - _startColor.B) * ratio);

            Color currentColor = Color.FromArgb(red, green, blue);
            // Set the background color here
            _i += _direction;

            if (_i == _steps || _i == 0)
            {
                _direction *= -1;
            }

            return currentColor;
        }
    }
}
