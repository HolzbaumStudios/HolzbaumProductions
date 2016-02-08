using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(CreateLevelMenuLayout))]
public class CreateLevelMenuLayoutEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CreateLevelMenuLayout myScript = (CreateLevelMenuLayout)target;


        if (GUILayout.Button("Build Canvas"))
        {
            myScript.CreateLayout();
        }
    }

}
