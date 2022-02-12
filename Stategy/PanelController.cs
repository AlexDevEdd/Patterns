using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Stategy
{
    public class PanelController : MonoBehaviour
    {
        [SerializeField] private Light[] _lights;

        public static PanelController instance;
        public AnimalBase curAnimalObj;
        public Dictionary<string, Action> behaviours;
        private bool move;
        private bool fly;
        private float timer;


        private void Awake()
        {
            instance = this;
        }
        private void Update()
        {          
            if (timer < 3)
            {
                timer += Time.deltaTime;

                if (move)
                    behaviours["move"].Invoke();
                if (fly)
                    behaviours["fly"].Invoke();
            }

        }
        public void Reset()
        {
            foreach (var light in _lights)
                light.enabled = false;
            move = false;
            fly = false;
            timer = 0;
        }
       
        public void MoveButton()
        {
            move = true;
            try
            {
                if (behaviours.Keys.Contains("move"))
                    behaviours["move"].Invoke();               
                else
                    behaviours["canNot"].Invoke();
            }
            catch (Exception e)
            {
                Debug.Log("Животное не выбрано! Кликните на животное!");
            }
        }
        public void SpeakButton()
        {
            try
            {
                if (behaviours.Keys.Contains("speak"))
                    behaviours["speak"].Invoke();
                else
                    behaviours["canNot"].Invoke();
            }
            catch (Exception e)
            {
                Debug.Log("Животное не выбрано! Кликните на животное!");
            }
        }
        public void EatButton()
        {
            try
            {
                if (behaviours.Keys.Contains("eat"))
                    behaviours["eat"].Invoke();
                else
                    behaviours["canNot"].Invoke();
            }
            catch (Exception e)
            {
                Debug.Log("Животное не выбрано! Кликните на животное!");
            }
        }
        public void FlyButton()
        {
            fly = true;
            try
            {
                if (behaviours.Keys.Contains("fly"))
                    behaviours["fly"].Invoke();
                else
                    behaviours["canNot"].Invoke();
            }
            catch (Exception e)
            {
                Debug.Log("Животное не выбрано! Кликните на животное!");
            }
        }
        public void SleepButton()
        {
            try
            {
                if (behaviours.Keys.Contains("sleep"))
                    behaviours["sleep"].Invoke();
                else
                    behaviours["canNot"].Invoke();
            }
            catch (Exception e)
            {
                Debug.Log("Животное не выбрано! Кликните на животное!");
            }
        }
        public void SwimButton()
        {
            try
            {
                if (behaviours.Keys.Contains("swim"))
                    behaviours["swim"].Invoke();
                else
                    behaviours["canNot"].Invoke();
            }
            catch (Exception e)
            {
                Debug.Log("Животное не выбрано! Кликните на животное!");
            }
        }

    }
}
