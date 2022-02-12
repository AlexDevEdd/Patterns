using System;
using UnityEngine;

namespace Assets.PlayerStates
{
    public class PlayerBehaviorAggressive : IPlayerBehavior
    {
        private GameObject _player;
        private Material _material;
        private Color _defaultColor = Color.black;
        private float _rotateSpeed = 50f;
        private float minimum = 1F;
        private float maximum = 2F;

        public PlayerBehaviorAggressive(GameObject player, Material material)
        {
            _player = player;
            _material = material;
        }
        public void Enter()
        {
            Debug.Log("Enter Aggressive BEHAVIOR");
            ChangeObjColor();
            SetDefaultPosition();          
        }

        public void Exit()
        {
            Debug.Log("Exit  Aggressive BEHAVIOR");
            SetDefaultColor();
            SetDefaultScale();
        }

        public void Update()
        {
            Debug.Log("Update  Aggressive BEHAVIOR");
            RotateObj();
            ScaleObj();
        }

        private void RotateObj()
        {
            _player.transform.Rotate(Vector3.right, _rotateSpeed * Time.deltaTime);
        }
        private void ScaleObj()
        {
            _player.transform.localScale = new Vector3(
             Mathf.PingPong(Time.time, maximum - minimum) + minimum,
             Mathf.PingPong(Time.time, maximum - minimum) + minimum,
             Mathf.PingPong(Time.time, maximum - minimum) + minimum);
        }
        private void ChangeObjColor()
        {
            _material.color = Color.red;
        }
        private void SetDefaultColor()
        {
            _material.color = _defaultColor;
        }
        private void SetDefaultScale()
        {
            _player.transform.localScale = new Vector3(1, 1, 1);
        }
        private void SetDefaultPosition()
        {
            _player.transform.position = new Vector3(0, 2, 0);
        }
    }
}
