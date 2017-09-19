using UnityEngine;
using System.Collections;

public class notLuckScript : MonoBehaviour {


    public GameObject luck;
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {

        Instantiate(luck, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(100f, 150f));

    }
}
