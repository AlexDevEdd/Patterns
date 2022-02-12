using Assets;
using Assets.PlayerStates;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Material _material;
    private Dictionary<Type, IPlayerBehavior> _behaviorsMap;
    private IPlayerBehavior _behaviorCurrent;

    private void Start()
    {
        InitBehaviors();
        SetBehaviorByDefault();
    }
    private void Update()
    {
        if (_behaviorCurrent != null)
            _behaviorCurrent.Update();
    }
    private void InitBehaviors()
    {
        _behaviorsMap = new Dictionary<Type, IPlayerBehavior>();

        _behaviorsMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive(_player, _material);
        _behaviorsMap[typeof(PlayerBehaviorAggressive)] = new PlayerBehaviorAggressive(_player, _material);
        _behaviorsMap[typeof(PlayerBehaviorIdle)] = new PlayerBehaviorIdle(_player, _material);

    }
    private void SetBehavior(IPlayerBehavior newBehavior)
    {
        if (_behaviorCurrent != null)
            _behaviorCurrent.Exit();

        _behaviorCurrent = newBehavior;
        _behaviorCurrent.Enter();
    }
    private void SetBehaviorByDefault()
    {
        SetBehaviorIdle();
    }
    private IPlayerBehavior GetBehavior<T>() where T : IPlayerBehavior
    {
        var type = typeof(T);
        return _behaviorsMap[type];
    }
    public void SetBehaviorIdle()
    {
        var behaviorIdle = GetBehavior<PlayerBehaviorIdle>();
        SetBehavior(behaviorIdle);
    }
    public void SetBehaviorAggressive()
    {
        var behaviorAggressive = GetBehavior<PlayerBehaviorAggressive>();
        SetBehavior(behaviorAggressive);
    }
    public void SetBehaviorActive()
    {
        var behaviorActive = GetBehavior<PlayerBehaviorActive>();
        SetBehavior(behaviorActive);
    }

}
