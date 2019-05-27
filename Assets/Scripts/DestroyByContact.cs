using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Diamond;
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "CircleGood") {
            Circle = other.gameObject;
            Spawn();
            Destroy(other.gameObject);
        }
        if (other.tag == "DiamondBad") {
            Diamond = other.gameObject;
            SpawnDiamond();
            Destroy(other.gameObject);
        }
    }

    void Spawn() {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane/2));
        Instantiate(Circle, screenPosition, Quaternion.identity);
    }

    void SpawnDiamond() {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane/2));
        Instantiate(Diamond, screenPosition, Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D other) {
        Circle = other.gameObject;
        Diamond = other.gameObject;
        Spawn();
        SpawnDiamond();
        Destroy(other.gameObject);
    }

}
