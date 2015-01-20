using UnityEditor;
using UnityEngine;

public class DataEditor : EditorWindow {

    public static string dataType;
    public static string dataKey;
    public static string originalData = "";

    void OnGUI(){
        GUILayout.Label(string.Format("Edit Data Of {0}", dataKey));
        originalData = GUILayout.TextField( originalData );
        if(GUILayout.Button("Save")){
            Save (originalData);
        }
    }

    void Save(string data){
        switch(dataType){
        case "string":
            PlayerPrefs.SetString(dataKey, data);
            break;
        case "int":
            PlayerPrefs.SetInt(dataKey, int.Parse(data));
            break;
        case "float":
            PlayerPrefs.SetFloat(dataKey, float.Parse(data));
            break;
        default:
            break;
        }
        PlayerPrefs.Save();
    }
}
