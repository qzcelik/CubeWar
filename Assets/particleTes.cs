using UnityEngine;
using System.Collections;

public class particleTes : MonoBehaviour {
    public ParticleSystem greenAnim,purpleAnim,orangeAnim,blackAnim;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "green")
            greenAnim.Play();
        if ( other.tag == "purple")
            purpleAnim.Play();
        if (other.tag == "luck")
            orangeAnim.Play();
        if (other.tag == "notLuck")
            blackAnim.Play();
    }
}
