using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float rh;
    float rv;
    public float rotSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        rh += mv * rotSpeed * Time.deltaTime;
        rv += mh * rotSpeed * Time.deltaTime;
        rv = Mathf.Clamp(rh, -70, 70);

        transform.eulerAngles = new Vector3(-rh, rv, 0);
    }
}
