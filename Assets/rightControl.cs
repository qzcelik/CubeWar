using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class rightControl : MonoBehaviour 
{
    public Text score,cani;
 
    int puan = 0,can=5;
    void Update()
    {
        score.text =""+puan;
        cani.text = ""+can;
        if (can <= 0 || puan<=-50)
        Application.LoadLevel(2);
         
   }
    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "green")
        {
            puan += 10;
            score.text = "  Puan : " + puan;
        }
        if (other.tag == "purple")
        {
            puan -= 10;
            score.text = "  Puan : " + puan;
        }
        
      
     }
   public void increasePuan(int amount)
    {
        puan += amount;
    }
   public void canAzalt(int a)
   {
       can+= a;
   }
   void OnDisable()
   {
       PlayerPrefs.SetInt("Score",(int)puan);
   }
}
