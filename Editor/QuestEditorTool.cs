using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuestEditorTool : EditorWindow
{

    [MenuItem("Window/DCD/Quest Manager Tool")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(QuestEditorTool));
    }

    void OnGUI()
    {
        
    }
}
