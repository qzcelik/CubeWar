using UnityEngine;
using System.Collections;

public class backMenu : MonoBehaviour {

	 
	
	 
	void Update () 
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
	}
}
