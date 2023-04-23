using IAmTakuu.SpookyLoader.Triggers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace IAmTakuu.SpookyLoader
{
    public class SpookySceneLoader : MonoBehaviour
    {
        #region FIELDS

        public bool isLoaded;
        [Tooltip("Add a prefab off your trigger to quickly reuse it.")]
        public SpookyTrigger spookyTriggerPrefab;

        #endregion

        #region METHODS

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

        #endregion
    }
}