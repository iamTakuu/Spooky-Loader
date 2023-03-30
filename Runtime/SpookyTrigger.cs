using Spooky_Loader;
using UnityEngine;
using UnityEngine.Events;

namespace Spooky_Loader
{
    /// <summary>
    /// This is a simple trigger that will invoke an event when the player enters the trigger.
    /// Can be used to load and unload scenes.
    /// </summary>
    [RequireComponent(typeof(BoxCollider))]
    public class SpookyTrigger : MonoBehaviour
    {
        public UnityEvent onSceneTrigger;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                onSceneTrigger?.Invoke();
            }
        }
    }
}
