using UnityEngine;
using System.Collections;

public class SampleScript : MonoBehaviour {

    const string DATA_KEY = "datakey";
    const string DATA = "hogehugapiyo";

    void OnGUI(){

        // Save Data
        if(GUI.Button(new Rect(10, 10, Screen.width - 20, Screen.height / 10), "Save")){
            PlayerPrefs.SetString(DATA_KEY, DATA);
            Debug.Log(string.Format("data saved -> {0}", DATA));
        }

        // Load Data
        if(GUI.Button(new Rect(10, 20 + Screen.height / 10, Screen.width - 20, Screen.height / 10), "Load")){
            if(PlayerPrefs.HasKey(DATA_KEY)){
                Debug.Log(string.Format("Data is {0}", PlayerPrefs.GetString(DATA_KEY, "")));
            } else {
                Debug.Log("data is not saved");
            }
        }
    }
}
