using System;
using System.Collections.Generic;
using System.Diagnostics;
using __Scripts.data;
using __Scripts.factory;
using __Scripts.Utils;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace __Scripts.hw1
{
    public class Launcher : MonoBehaviour
    {
        private NegativeValueCounter _negativeValueCounter;
        
        private void Awake()
        {
            CreateObjects();
            CalculateNegativeValueFromList();
        }

        private void CreateObjects()
        {
            var factoryProducer = ObjectFactoryProducer.Create();

            _negativeValueCounter = factoryProducer.GetInstance<NegativeValueCounter>();
        }
        private void CalculateNegativeValueFromList()
        {
            var listData = Data.GenerateIntValueList(-50, 50, 100);
            var count = _negativeValueCounter.Calculate(listData);
            Debug.Log($"This list contains {count} negative elements.");
        }
    }
}
