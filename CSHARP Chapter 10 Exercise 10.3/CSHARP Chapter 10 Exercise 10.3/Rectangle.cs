using System;
public class Rectangle
{
    private float _length = 1;
    private float _width = 1;
    private float _perimeter = 0;
    private float _area = 0;

    public Rectangle(float length, float width)
    {
        Length = length;
        Width = width;
        Perimeter = (_length * 2) + (_width * 2);
        Area = _length * _width;
    }
    private float Length
    {
        get
        {
            return _length;
        }
        set
        {
            if ((value > 0.0) && (value < 20.0))
                _length = value;
            else
                throw new Exception("Length input error, number must be greater than 0, and less than 20");
        }
    }
    private float Width
    {
        get
        {
            return _width;
        }
        set
        {
            if ((value > 0.0) && (value < 20.0))
                _width = value;
            else
                throw new Exception("Width input error, number must be greater than 0, and less than 20");
        }
    }
    public float Perimeter
    {
        get
        {
            return _perimeter;
        }
        private set
        {
            _perimeter = value;
        }
    }
    public float Area
    {
        get
        {
            return _area;
        }
        private set
        {
            _area = value;
        }
    }
}
