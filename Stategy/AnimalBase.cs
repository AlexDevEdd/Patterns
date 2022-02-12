using Assets.Stategy.Helper.Interfaces;
using Assets.Stategy.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    protected float _speed = 0.2f;

    protected IMove _moveBehaviour;
    protected ICanNot _canNotBehaviour;
    protected IEat _eatBehaviour;
    protected IFly _flyBehaviour;
    protected ISleep _sleepBehaviour;
    protected ISpeak _speakBehaviour;
    protected ISwim _swimBehaviour;
    protected IWalk _wakBehaviour;

    public void SetMove(IMove moveBehaviour)
    {
        _moveBehaviour = moveBehaviour;        
    }public void SetCanNot(ICanNot canNotBehaviour)
    {
        _canNotBehaviour = canNotBehaviour;
    }public void SetEat(IEat eatBehaviour)
    {
        _eatBehaviour = eatBehaviour;
    }
    public void SetFly(IFly flyBehaviour)
    {
        _flyBehaviour = flyBehaviour;
    }public void SetSleep(ISleep sleepBehaviour)
    {
        _sleepBehaviour = sleepBehaviour;
    }public void SetSpeak(ISpeak speakBehaviour)
    {
        _speakBehaviour = speakBehaviour;
    }public void SetSwim(ISwim swimBehaviour)
    {
        _swimBehaviour = swimBehaviour;
    }public void SetWalk(IWalk wakBehaviour)
    {
        _wakBehaviour = wakBehaviour;
    }


    protected void Sleep()
    {
        _sleepBehaviour.Sleep();
    }
    protected void Eat()
    {
        _eatBehaviour.Eat();
    } 
    protected void Move()
    {
        _moveBehaviour.Move();
    }
    protected void Speak()
    {
        _speakBehaviour.Speak();
    } 
    protected void Fly()
    {
        _flyBehaviour.Fly();
    }
    protected void Swim()
    {
        _swimBehaviour.Swim();
    }
     protected void CanNot()
    {
        _canNotBehaviour.CanNot();
    }

}
