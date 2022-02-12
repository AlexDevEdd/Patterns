using Assets.Stategy.Interfaces;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class WalkWithTwoLegsBehaviour : IMove
{
    private TextMeshProUGUI _text;
    private Transform _transform;
    private float _speed;
    public WalkWithTwoLegsBehaviour(Transform transform, float speed, TextMeshProUGUI text)
    {
        _speed = speed;
        _transform = transform;
        _text = text;
    }
    public void Move()
    {
        MoveObj();
        ShowText(_text, "Я хожу на 2 лапах");
        DisableText(_text);
    }

    private void MoveObj() => _transform.Translate(Vector3.forward * _speed * Time.deltaTime);

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
