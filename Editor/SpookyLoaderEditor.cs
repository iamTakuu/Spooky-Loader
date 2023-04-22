using IAmTaku.SpookyLoader.Triggers;
using UnityEditor;
using UnityEditor.Events;
using UnityEngine;

namespace IAmTaku.SpookyLoader.Editors
{
    [CustomEditor(typeof(SpookySceneLoader))]
    public class SpookyLoaderEditor : Editor
    {
        #region FIELDS

        private SpookySceneLoader _spookySceneLoader;

        #endregion

        #region UNITY METHODS

        private void OnEnable()
        {
            _spookySceneLoader = target as SpookySceneLoader;
        }

        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Add Trigger"))
            {
                CreateTrigger();
            }
            DrawDefaultInspector();
        }

        #endregion

        #region METHODS

        private void CreateTrigger()
        {
            Transform spookyTransform = _spookySceneLoader.transform;
            SpookyTrigger spookyTrigger = Instantiate(_spookySceneLoader.spookyTriggerPrefab,
                                                      spookyTransform.position,
                                                      spookyTransform.rotation,
                                                      spookyTransform);
            spookyTrigger.name = "SpookyTrigger";
            UnityEventTools.AddPersistentListener(spookyTrigger.onSceneTrigger, _spookySceneLoader.OnSceneTrigger);
        }

        #endregion
    }
}