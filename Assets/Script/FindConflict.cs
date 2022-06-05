using UnityEditor;
using UnityEngine;

public class GUIDToAssetPathExample : MonoBehaviour
{
    [MenuItem("APIExamples/GUIDToAssetPath")]
    static void MaterialPathsInProject()
    {
        var allMaterials = AssetDatabase.FindAssets("t: Material");
        /*
        foreach (var guid in allMaterials)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            Debug.Log(path);
        }*/
        var path = AssetDatabase.GUIDToAssetPath("0e7ee4df08df88c4880f43398f9ad2c2");
        
        Debug.Log(path);
        path = AssetDatabase.GUIDToAssetPath("0fb4610dba67fc24cb2a6674fb155fc1");
        Debug.Log(path);
        path = AssetDatabase.GUIDToAssetPath("8b529144aad05a345b8670c9d0598f6a");
        Debug.Log(path);
    }
}
