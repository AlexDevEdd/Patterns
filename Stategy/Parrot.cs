using Assets.Stategy;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Parrot : AnimalBase
{
    public Dictionary<string, Action> behaviours;
    [SerializeField] private Material _material;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Light _light;


    private void Awake()
    {
        SetMove(new WalkWithTwoLegsBehaviour(this.transform, _speed, _text));
        SetFly(new FlyBehaviour(this.transform, _speed, _text));
        SetSpeak(new SpeakBehaviour(_text));
        SetEat(new EatBehaviour(_text));
        SetSleep(new SleepBehaviour(_text));    
        SetCanNot(new CanNotBehaviour(_text));

        behaviours = new Dictionary<string, Action>()
        {
            {"move", Move },
            {"fly", Fly },
            {"speak", Speak },
            {"eat", Eat },
            {"sleep", Sleep },
            {"canNot", CanNot }
        };
    }
    private void OnMouseDown()
    {
        PanelController.instance.Reset();
        PanelController.instance.curAnimalObj = this;
        PanelController.instance.behaviours = behaviours;
        _light.enabled = true;
    }
}
