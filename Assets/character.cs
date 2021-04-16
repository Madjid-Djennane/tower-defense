using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    public float speed;
    // public GameObject bullet;
    // public Transform enemyTransform;

    void Update() {

        if (Input.GetKey(KeyCode.Z)) {
            transform.position += new Vector3(0, 0, 1) * speed;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(0, 0, -1) * speed;
        }

        if (Input.GetKey(KeyCode.Q)) {
            transform.position += new Vector3(-1, 0, 0) * speed;
        }

        if (Input.GetKey(KeyCode.D)) {
            gameObject.transform.position += new Vector3(1, 0, 0) * speed;
        }

    }
}

