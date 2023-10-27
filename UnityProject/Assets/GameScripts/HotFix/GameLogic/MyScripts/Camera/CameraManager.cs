using System.Collections;
using System.Collections.Generic;
using TEngine;
using UnityEngine;

namespace GameLogic
{
    public class CameraManager : BehaviourSingleton<CameraManager>
    {
        public Camera mainCamera;
        public override void Awake()
        {
            base.Awake();
            InitCamera();
        }

        private void InitCamera()
        {
            mainCamera = Camera.main;
            GameObject.DontDestroyOnLoad(mainCamera.gameObject);
        }
    }
}
