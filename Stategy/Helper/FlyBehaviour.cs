using Assets.Stategy.Helper.Interfaces;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class FlyBehaviour : IFly
{
    private TextMeshProUGUI _text;
    private Transform _transform;
    private float _speed = 2f;
    public FlyBehaviour(Transform transform, float speed, TextMeshProUGUI text)
    {
        _speed = speed;
        _transform = transform;
        _text = text;
    }

    public void Fly()
    {
        FlyObj();
        ShowText(_text, "Я лечу!");
        DisableText(_text);
    }

    private void FlyObj() => _transform.Translate(Vector3.up * _speed * Time.deltaTime);

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
