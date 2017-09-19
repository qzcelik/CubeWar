using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class downObject : MonoBehaviour {

    public GameObject down,down3,down2,down4,down5,down6;
 
    int s = 0, puan = 0;
   
    void Start () 
    {
        Spawn();
    }
    void Spawn()
    {
       
        puan++;
        if (puan <= 7)
        {
            s++;
            
            if (s % 3 == 0)
            {
                Instantiate(down, transform.position, Quaternion.identity);
                Invoke("Spawn", Random.Range(6f, 8f));
            }
            else
            {
                Instantiate(down3, transform.position, Quaternion.identity);
                Invoke("Spawn", Random.Range(5f, 10f));
            }
            
        }
        else   if(puan>7 && puan<=27)
        {
             s++;
             
             if (s % 3 == 0)
             {
                 Instantiate(down2, transform.position, Quaternion.identity);
                Invoke("Spawn", Random.Range(6f, 8f));
             }
             else
             {
                Instantiate(down4, transform.position, Quaternion.identity);
                 Invoke("Spawn", Random.Range(5f, 10f));
             }
          
        }    
        else if(puan>=27)
        {
             s++;
             
             if (s % 3 == 0)
             {
                 Instantiate(down5, transform.position, Quaternion.identity);
                Invoke("Spawn", Random.Range(6f, 8f));
             }
             else
             {
                Instantiate(down6, transform.position, Quaternion.identity);
                 Invoke("Spawn", Random.Range(5f, 10f));
             }
             
        }    
        }
}
