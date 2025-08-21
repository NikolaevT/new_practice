using System.Globalization;

namespace Tusk2;

class StringNewGenerate
{
    private string _value;

    public StringNewGenerate()
    {
        _value = "";
    }
    public StringNewGenerate(int number)
    {
        _value = number.ToString();
    }
    public StringNewGenerate(string str)
    {
        _value = str ?? "";
    }

    public int GetLenght()
    {
        return _value.Length;
    }
    public void Clear()
    {
        _value = "";
    }

    public string Get()
    {
        return _value;
    }

    public void Add(int number)
    {
        _value += number.ToString();
    }

    public void Add(string str)
    {
        _value += str;
    }

    public override string ToString()
    {
        return $"Hello, string: [{_value}]";
    }

}