using TMPro;

public class TextChange : IRelouded
{
    private TextMeshProUGUI _text;
    private int _value;
    public TextChange (TextMeshProUGUI text, int score)
    {
        _text = text;
        _value = score;

        Reload(_value);
    }
    public void Reload(int score)
    {
        _value = score;

        _text.text = $"Вы нажали: {_value} раз по экрану!";
    }
}