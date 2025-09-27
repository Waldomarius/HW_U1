using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

namespace __Scripts.factory
{
    /**
     * Class factory to create new instance for objects.
     */
    public class ObjectFactoryProducer
    {
        /**
         * Instance of this class.
         */
        private static ObjectFactoryProducer _factoryProducer;
        
        /**
         * List created instances.
         */
        private readonly Dictionary<string, Object> _objectInstances;
        private ObjectFactoryProducer()
        {
            _objectInstances = new Dictionary<string, Object>();
        }

        /**
         * Create instance of this class.
         */
        public static ObjectFactoryProducer Create()
        {
            Debug.Log("Create ObjectFactoryProducer to create instanses.");
            return _factoryProducer ??= new ObjectFactoryProducer();
        }
        
        /**
         * Return instance for object T.
         */
        public T GetInstance<T>()
            where T : new ()
        {
            if (_objectInstances.ContainsKey(typeof(T).Name))
            {
                Debug.Log($"Load instance for object {typeof(T).Name} from list instances.");
                return (T) _objectInstances[typeof(T).Name];
            }
            
            var newInstance = new T();
            _objectInstances.Add(typeof(T).Name,newInstance);
            Debug.Log($"Create new instance for object {typeof(T).Name}");
            return newInstance;
        }
    }
}