using UnityEngine;
using System.Collections;
 
public class yesSound : MonoBehaviour {

    int s = 0;
   
    public void soundOn()
    {
       
         s++;
        if (s % 2 == 0)
             AudioListener.volume = 1;
         else
            AudioListener.volume = 0;

         
    }
}
