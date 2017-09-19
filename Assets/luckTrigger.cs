using UnityEngine;
using System.Collections;

public class luckTrigger : MonoBehaviour {
    rightControl send;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            send=GameObject.Find("destroyerRight").GetComponent<rightControl>();
            send.increasePuan(100);
            send.canAzalt(2);
            Destroy(this.gameObject);
        }
         
           if (other.tag == "destroyer2")
           {
               Destroy(this.gameObject);
           }
      
    }

    
}
