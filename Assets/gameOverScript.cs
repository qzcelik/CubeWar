using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour {

    public Text puan,highPuan;

    int score=0;
	void Start () 
    {
       
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        score=PlayerPrefs.GetInt("Score");// elde edilen puan il etapta karşı taraftan alınıyor.
        if (score > PlayerPrefs.GetInt("score"))
        PlayerPrefs.SetInt("score",score);//hafızada tutulacak değer karşıya gönderiliyor high score oldu
        puan.text=("   Score : "+score);
        highPuan.text=("High Score : "+PlayerPrefs.GetInt("score"));
    }
	
	 
}
