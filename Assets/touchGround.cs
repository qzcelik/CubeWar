using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touchGround : MonoBehaviour 

{
   public AudioClip ses1,ses2;
    public ParticleSystem anim;
     
      void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.tag == "destroyer")
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(ses1, Vector3.zero, 1.0f);
        }
        if (other.tag == "destroyer2")
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(ses2, Vector3.zero, 1.0f);
        }
       
    
   }
	 
	
}
