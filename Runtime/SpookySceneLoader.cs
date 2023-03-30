using UnityEditor.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Spooky_Loader
{
    public class SpookySceneLoader : MonoBehaviour
    {
        public bool isLoaded;
        [Tooltip("Add a prefab off your trigger to quickly reuse it.")]
        public GameObject _triggerPrefab;
        
        public void OnSceneTrigger()
        {
            if (!isLoaded)
            {
                LoadScene();
                return;
            }
            UnLoadScene();
        }
        
        private void LoadScene()
        {
            SceneManager.LoadSceneAsync(gameObject.name, LoadSceneMode.Additive);
            isLoaded = true;
        }
        
        private void UnLoadScene()
        {
            SceneManager.UnloadSceneAsync(gameObject.name); 
            isLoaded = false;
        }

#if UNITY_EDITOR
        public void CreateTrigger()
        {
            var _sceneTrigger = Instantiate(_triggerPrefab, transform);
            _sceneTrigger.name = "SpookyTrigger";
            _sceneTrigger.transform.position = transform.position;
            _sceneTrigger.transform.rotation = transform.rotation;
            _sceneTrigger.transform.localScale = transform.localScale;
            
            UnityEventTools.AddPersistentListener(_sceneTrigger
                .GetComponent<SpookyTrigger>()
                .onSceneTrigger, OnSceneTrigger);
            
        } 
#endif
        
    }
}
