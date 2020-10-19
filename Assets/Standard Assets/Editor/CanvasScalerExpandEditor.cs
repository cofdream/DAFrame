using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CustomEditor(typeof(CanvasScalerExpand)), CanEditMultipleObjects]
public class CanvasScalerExpandEditor : Editor
{
    static string error = "not has a type of CanvasScaler component.Please AddCommpanent";
    static string add = "Add CanvasScalerExpand Companent";
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        bool isCanvasScalerExpand = false;
        for (int i = 0; i < targets.Length; i++)
        {
            CanvasScalerExpand canvasScalerExpand = (targets[i] as CanvasScalerExpand);

            CanvasScaler canvasScaler;
            if (canvasScalerExpand.TryGetComponent(out canvasScaler) == false)
            {
                if (GUILayout.Button(add))
                {
                    canvasScalerExpand.gameObject.AddComponent<CanvasScaler>();
                }
                else
                {
                    isCanvasScalerExpand = true;
                }
            }
        }

        if (isCanvasScalerExpand)
        {
            EditorGUILayout.HelpBox(error, MessageType.Error);
        }
    }
}