#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace FoBBB
{
    [CustomEditor(typeof(NoteComponent))]
    [CanEditMultipleObjects]
    public class NoteComponentEditor : Editor
    {
        protected SerializedProperty note;

        #region Method

        void OnEnable()
        {
            this.note = base.serializedObject.FindProperty("note");
        }

        public override void OnInspectorGUI()
        {
            base.serializedObject.Update();

            EditorGUILayout.PropertyField(this.note, GUIContent.none);

            base.serializedObject.ApplyModifiedProperties();
        }

        #endregion Method
    }
}

#endif // UNITY_EDITOR