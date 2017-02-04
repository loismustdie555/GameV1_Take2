using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestScript : MonoBehaviour {
    // Use this for initialization
    Text test;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        test.text = Input.GetAxis("Vertical").ToString();
    }
}
