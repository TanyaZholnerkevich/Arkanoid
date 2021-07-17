using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    [SerializeField]
    float speed = 20f;
    void Update()
    {
        transform.Translate(speed * Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 9f), transform.position.y, transform.position.z);
    }
}
