using UnityEngine;

public class Sample : MonoBehaviour
{
    protected void OnGUI()
    {
        ObjectCountChecker checker = ObjectCountChecker.Instance;

        GUILayout.BeginArea(new Rect(50, 50, 300, 300));

        GUILayout.Label("Object     : " + checker.ObjectCount     + " / " + checker.ObjectCountMax);
        GUILayout.Label("Texture    : " + checker.TextureCount    + " / " + checker.TextureCountMax);
        GUILayout.Label("AudioClip  : " + checker.AudioClipCount  + " / " + checker.AudioClipCountMax);
        GUILayout.Label("Mesh       : " + checker.MeshCount       + " / " + checker.MeshCountMax);
        GUILayout.Label("Material   : " + checker.MaterialCount   + " / " + checker.MaterialCountMax);
        GUILayout.Label("GameObject : " + checker.GameObjectCount + " / " + checker.GameObjectCountMax);
        GUILayout.Label("Component  : " + checker.ComponentCount  + " / " + checker.ComponentCountMax);

        GUILayout.EndArea();
    }
}