using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public float speed;

    Vector3 zero = new Vector3(0,0,0);
    int low = 5;

    void FixedUpdate()
    {
        transform.LookAt(zero);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > low))
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
