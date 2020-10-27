using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public int rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rx = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.right * rx * -rotateSpeed);
    }
}
