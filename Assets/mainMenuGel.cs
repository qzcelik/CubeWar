using UnityEngine;
using System.Collections;

public class mainMenuGel : MonoBehaviour {
    public void anaGel()
    {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
        Application.LoadLevel(0);
    }
}
