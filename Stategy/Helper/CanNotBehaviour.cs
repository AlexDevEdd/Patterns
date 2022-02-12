using Assets.Stategy.Helper.Interfaces;
using System.Threading.Tasks;
using TMPro;

public class CanNotBehaviour : ICanNot
{
    private TextMeshProUGUI _text;
    public CanNotBehaviour(TextMeshProUGUI text)
    {
        _text = text;
    }

    public void CanNot()
    {
        ShowText(_text, "Я не умею");
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
