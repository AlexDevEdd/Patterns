using Assets.Stategy;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dog : AnimalBase
{
    public Dictionary<string, Action> behaviours;
    [SerializeField] private Material _material;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Light _light;

    private void Awake()
    {      
        SetSpeak(new BawBehaviour(_text));
        SetMove(new WalkWithFourLegsBehaviour(transform, _speed, _text));
        SetEat(new EatBehaviour(_text));
        SetSleep(new SleepBehaviour(_text));
        SetSwim(new SwimBehaviour(_text));
        SetCanNot(new CanNotBehaviour(_text));

        behaviours = new Dictionary<string, Action>()
        {
            {"speak", Speak },
            {"move", Move },
            {"eat", Eat },
            {"sleep", Sleep },
            {"swim", Swim },
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
