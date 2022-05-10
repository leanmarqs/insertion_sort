using System;


public static class Tools
{
    public static void setValues(int[] _values, string[] _search)
    {
        for (int _i = 0; _i < _search.Length; _i++)
        {
            _values[_i] = Int32.Parse(_search[_i]);
        }
    }

    public static void printValues(int[] _values)
    {
        for (int _i = 0; _i < _values.Length; _i++)
        {
            System.Console.Write(_values[_i] + (_i < _values.Length - 1 ? ", " : "\n"));
        }
    }

    public static void printValues(string[] _values)
    {
        for (int _i = 0; _i < _values.Length; _i++)
        {
            System.Console.Write(_values[_i] + (_i < _values.Length - 1 ? ", " : "\n"));
        }
    }
}

public static class InsertSort
{
    public static void sort(int[] _values)
    {
        for (int _j = 1; _j < _values.Length; _j++)
        {
            int _value = _values[_j];
            int _i = _j - 1;
            while (_i >= 0 && _values[_i] > _value)
            {
                _values[_i + 1] = _values[_i];
                _i -= 1;
            }
            _values[_i + 1] = _value;
        }
    }

}

class Program
{
    
    static public void Main(string[] _args)
    {
        int[] _values = new int[_args.Length];
        Tools.printValues(_args);
        Tools.setValues(_values, _args);
        InsertSort.sort(_values);
        Tools.printValues(_values);
    }

    

}
