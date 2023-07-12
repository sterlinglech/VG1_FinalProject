using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinalProject
{
    public class Person : MonoBehaviour
    {
        // Configuration
        public int maxShieldCharges;
        public int shieldCharges;

        // State Tracking

        // Methods
        private void Start()
        {
            shieldCharges = 0;
        }
    }
}
