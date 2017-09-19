using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deneme : MonoBehaviour  
{
    rightControl send;
   void OnTriggerEnter2D(Collider2D other)
    {
        int puan = 0;
        send = GameObject.Find("destroyerRight").GetComponent<rightControl>();
         
            if (other.tag == "purple")
            {
                puan += 10;
                send.increasePuan(puan);

            }
            if (other.tag == "green")
            {
                puan -= 10;
                send.increasePuan(puan);
           }
        }
        
         
     
	 
	
}
