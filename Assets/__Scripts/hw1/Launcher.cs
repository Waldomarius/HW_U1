using __Scripts.data;
using __Scripts.factory;
using __Scripts.Utils;
using __Scripts.Utils.sorts;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace __Scripts.hw1
{
    public class Launcher : MonoBehaviour
    {
        private PositiveValueCounter _positiveValueCounter;

        private ShellSort _shellSortSort; 
        
        private void Start()
        {
            CreateObjects();
            CalculatePsitiveValueFromList();
            SortList();
        }

        private void CreateObjects()
        {
            var factory = ObjectFactoryProducer.Create();

            _positiveValueCounter = factory.GetInstance<PositiveValueCounter>();
            _shellSortSort = factory.GetInstance<ShellSort>();
        }
        private void CalculatePsitiveValueFromList()
        {
            var listData = Data.GenerateIntValueList(-50, 50, 100);
            var count = _positiveValueCounter.Calculate(listData);
            Debug.Log($"This list contains {count} positive elements.");
        }
        
        private void SortList()
        {
            var listData = Data.GenerateIntValueList(-50, 50, 50);
            _shellSortSort.Sort(listData);
            Debug.Log($"Sorted {listData.Count} elements.");
        }
    }
}
