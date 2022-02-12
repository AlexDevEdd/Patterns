using Assets.Stategy.Helper.Interfaces;
using System.Threading.Tasks;
using TMPro;

public class BawBehaviour : ISpeak
{
    private TextMeshProUGUI _text;
    public BawBehaviour(TextMeshProUGUI text)
    {
        _text = text;
    }
    public void Speak()
    {
        ShowText(_text, "√‡Ù!√‡Ù!ﬂ Î‡˛!");
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
