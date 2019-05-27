using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadObject : MonoBehaviour
{

    public GameObject diamond;
    public float spawntime = 0.5f;
    public float fallspeed = 70.0f;

    private float timerD = 0;
    private int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerD += Time.deltaTime;
        if (timerD > spawntime) {
            Spawn();
            timerD = 0;
        }
    }

    public void Spawn() {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane/2));
        Instantiate(diamond, screenPosition, Quaternion.identity);
    }
}
