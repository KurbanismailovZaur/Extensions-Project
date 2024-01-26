using System;
using Codomaster.Extensions;
using UnityEngine;

namespace DefaultNamespace
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            var max = Vector3.forward.MaxComponent();
        }
    }
}