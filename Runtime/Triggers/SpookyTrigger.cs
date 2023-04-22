using UnityEngine;
using UnityEngine.Events;

namespace IAmTaku.SpookyLoader.Triggers
{
    /// <summary>
    /// This is a simple trigger that will invoke an event when the player enters the trigger.
    /// Can be used to load and unload scenes.
    /// </summary>
    [RequireComponent(typeof(BoxCollider))]
    public class SpookyTrigger : MonoBehaviour
    {
        #region FIELDS

        [Header("Events")]
        public UnityEvent onSceneTrigger;

        #endregion

        #region UNITY METHODS

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                onSceneTrigger?.Invoke();
            }
        }

        #endregion
    }
}