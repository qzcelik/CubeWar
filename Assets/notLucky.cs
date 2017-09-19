using UnityEngine;
using System.Collections;

public class notLucky : MonoBehaviour {
    rightControl send;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            send = GameObject.Find("destroyerRight").GetComponent<rightControl>();
            send.increasePuan(-50);
            send.canAzalt(-1);
            Destroy(this.gameObject);
        }
     if (other.tag == "destroyer2")
        {
            Destroy(this.gameObject);
        }

    }
}
