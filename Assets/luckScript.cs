using UnityEngine;
using System.Collections;

public class luckScript : MonoBehaviour
{
      public GameObject luck;
      void Start()
      {
          Spawn();
      }
     
       void Spawn()
       {
           
               Instantiate(luck, transform.position, Quaternion.identity);
               Invoke("Spawn", Random.Range(60f, 70f));

       }

      
}
