using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewFile : MonoBehaviour {
    public Button File;
    private Canvas Background;
    private Vector3 position;
    private Quaternion rotation;

	// Use this for initialization
	void Start () {
        position = new Vector3(-200, 165, 0);
        rotation = File.transform.rotation;
        Background = GameObject.Find("Canvas").GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Button newFile = Instantiate(File, position, rotation,Background.transform);
        newFile.transform.localPosition = position;

        newFile.GetComponentInChildren<Text>().text = "File1";
    }
}
