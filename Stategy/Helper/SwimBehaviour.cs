using Assets.Stategy.Helper.Interfaces;
using System.Threading.Tasks;
using TMPro;

public class SwimBehaviour : ISwim
{
    private TextMeshProUGUI _text;
    public SwimBehaviour(TextMeshProUGUI text)
    {
        _text = text;
    }
    public void Swim()
    {
        ShowText(_text, "Я плаваю!");
        DisableText(_text);
    }

    private void ShowText(TextMeshProUGUI text, string messege)
    {
        text.gameObject.SetActive(true);
        text.text = messege;
    }
    private async void DisableText(TextMeshProUGUI text)
    {
        await Task.Delay(1500);
        text.gameObject.SetActive(false);
    }
}
