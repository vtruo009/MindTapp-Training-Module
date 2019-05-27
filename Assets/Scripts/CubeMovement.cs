using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    void FixedUpdate() {
        //input
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Vector3 position = this.transform.position;
            position.x = position.x-.1F;
            if (position.x > -2.3) {
                this.transform.position = position;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Vector3 position = this.transform.position;
            // position.x++;
            position.x = position.x+.1F;
            if (position.x < 2.3) {
                this.transform.position = position;
            }
        }
    }
}
