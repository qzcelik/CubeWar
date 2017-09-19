using UnityEngine;
using System.Collections;

public class middleControl : MonoBehaviour
{
     rightControl send;
	 void OnTriggerEnter2D(Collider2D other)
     {

         send = GameObject.Find("destroyerRight").GetComponent<rightControl>();
         if (other.tag == "purple")
         {
             send.canAzalt(-1);
             send.increasePuan(-10);
         }
         if (other.tag == "green")
         {
             send.canAzalt(-1);
             send.increasePuan(-10);
         }

     }
}
