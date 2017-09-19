using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class hareket : MonoBehaviour {

    
    public float moveForce = 5;
    public float hopla=5;
    Rigidbody2D mybody;
   public AudioClip ses1,ses2;
   public void resetPoz()
   {  
       transform.position=Vector3.zero;
       mybody.velocity = Vector3.zero;
   }
     void Start () 
     {
     
         mybody = GetComponent<Rigidbody2D>();
	 }
    void Update ()
    {
        bool ayniAndaBas;
        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        ayniAndaBas = CrossPlatformInputManager.GetButton("hopla");
        mybody.AddForce(moveVec*(ayniAndaBas?hopla:1));
   }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "luck")
        {
            AudioSource.PlayClipAtPoint(ses1, Vector3.zero, 1.0f);
        }
        if (other.tag == "notLuck")
        {
            AudioSource.PlayClipAtPoint(ses2, Vector3.zero, 1.0f);
        }      
    }
}
