using System;
using UnityEngine;

namespace Assets.PlayerStates
{
    public class PlayerBehaviorActive : IPlayerBehavior
    {
        private GameObject _player;
        private Material _material;
        private Color _defaultColor = Color.cyan;
        private float _rotateSpeed = 50f;

        public PlayerBehaviorActive(GameObject player, Material material)
        {
            _player = player;
            _material = material;
        }
      
        public void Enter()
        {
            Debug.Log("Enter ACTIVE BEHAVIOR");
            ChangeObjColor();
            SetDefaultPosition();
        }

        public void Exit()
        {
            Debug.Log("Exit  ACTIVE BEHAVIOR");
            SetDefaultColor();
        }

        public void Update()
        {
            Debug.Log("Update  ACTIVE BEHAVIOR");
            RotateObj();
        }
        private void RotateObj()
        {
            _player.transform.Rotate(Vector3.up, _rotateSpeed * Time.deltaTime);
        }
        private void ChangeObjColor()
        {
            _material.color = Color.yellow;
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
