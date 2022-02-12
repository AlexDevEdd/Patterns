using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTes : MonoBehaviour
{
    [SerializeField] PlayerBehavior player;

    void Update()
    {
        InputTest();
    }

    private void InputTest()
    {
        if (Input.GetKeyDown(KeyCode.A))
            player.SetBehaviorAggressive();
        if (Input.GetKeyDown(KeyCode.S))
            player.SetBehaviorActive();
        if (Input.GetKeyDown(KeyCode.D))
            player.SetBehaviorIdle();
    }
} 
