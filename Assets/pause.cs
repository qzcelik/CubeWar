using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
    int say=0;
	 public void dur ()
    {
        say++;
        if (say % 2 != 0)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
	}
}
