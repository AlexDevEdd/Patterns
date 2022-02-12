using Assets.Stategy.Helper.Interfaces;
using System.Threading.Tasks;
using TMPro;

public class SleepBehaviour : ISleep
{
    private TextMeshProUGUI _text;
    public SleepBehaviour(TextMeshProUGUI text)
    {
        _text = text;
    }
    public void Sleep()
    {
        ShowText(_text, "Я люблю спать!");       
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
