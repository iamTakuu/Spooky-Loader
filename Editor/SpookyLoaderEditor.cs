using Spooky_Loader;
using UnityEditor;
using UnityEngine;

    [CustomEditor(typeof(SpookySceneLoader))]
    public class SpookyLoaderEditor : Editor
    {
        private GameObject _sceneTrigger;
        public override void OnInspectorGUI()
        {
            var sceneLoader = target as SpookySceneLoader;
            sceneLoader.isLoaded = EditorGUILayout.Toggle("Is Loaded", sceneLoader.isLoaded);
            sceneLoader._triggerPrefab = EditorGUILayout.ObjectField("Trigger Prefab"
                , sceneLoader._triggerPrefab
                , typeof(GameObject), false) as GameObject;
            
            if (GUILayout.Button("Add Trigger"))
            {
                sceneLoader.CreateTrigger();
            }
        }
    }

