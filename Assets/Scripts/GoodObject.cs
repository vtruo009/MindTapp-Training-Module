using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodObject : MonoBehaviour
{
    public GameObject circle;
    public float spawnTime = 0.5f;
    public float fallSpeed = 70.0f;

    private float timer = 0;
    private int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime) {
            Spawn();
            timer = 0;
        }
    }

    public void Spawn() {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane/2));
        Instantiate(circle, screenPosition, Quaternion.identity);
    }
}
