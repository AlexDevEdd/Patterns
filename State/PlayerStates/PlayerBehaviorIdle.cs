using System;
using UnityEngine;

namespace Assets.PlayerStates
{
    public class PlayerBehaviorIdle : IPlayerBehavior
    {
        private GameObject _player;
        private Material _material;
        private float _rotateSpeed = 50f;
        private Color _defaultColor = Color.cyan;
        public PlayerBehaviorIdle(GameObject player, Material material)
        {
            _player = player;
            _material = material;
        }
        public void Enter()
        {
            Debug.Log("Enter IDLE BEHAVIOR");
            SetDefaultColor();
            SetDefaultPosition();
        }


        public void Exit()
        {
            Debug.Log("Exit  IDLE BEHAVIOR");
            SetDefaultColor();
            SetDefaultScale();
        }

        public void Update()
        {
            Debug.Log("Update  IDLE BEHAVIOR");
            RotateObj();
        }

        private void RotateObj()
        {
            _player.transform.Rotate(new Vector3(1, 1, 1), _rotateSpeed * Time.deltaTime);
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
