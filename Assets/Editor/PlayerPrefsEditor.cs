using UnityEditor;
using UnityEngine;

public class PlayerPrefsEditor : EditorWindow {

    string stringKey = "";
    string intKey = "";
    string floatKey = "";

    [MenuItem("Tools/PlayerPrefs/DeleteAll")]
    static void DeleteAll(){
        PlayerPrefs.DeleteAll();
        Debug.Log("Delete All Data Of PlayerPrefs!!");
    }

    [MenuItem("Tools/PlayerPrefs/OpenEditor")]
    static void OpenEditor(){
        EditorWindow.GetWindow<PlayerPrefsEditor>("PlayrePrefsEditor");
    }

    void OnGUI(){
        GUILayout.Label( "Input PlayerPrefs Key Here" );
        GUILayout.Label( "String Value" );
        stringKey = GUILayout.TextField( stringKey );
        if(PlayerPrefs.HasKey(stringKey)){
            string data = PlayerPrefs.GetString(stringKey);
            GUILayout.Label(data);
        }

        GUILayout.Label("Int Value");
        intKey = GUILayout.TextField(intKey);
        if(PlayerPrefs.HasKey(intKey)){
            string data = PlayerPrefs.GetInt(intKey).ToString();
            GUILayout.Label(data);
        }

        GUILayout.Label("Float Value");
        floatKey = GUILayout.TextField(floatKey);
        if(PlayerPrefs.HasKey(floatKey)){
            string data = PlayerPrefs.GetFloat(floatKey).ToString();
            GUILayout.Label(data);
        }
    }
}
