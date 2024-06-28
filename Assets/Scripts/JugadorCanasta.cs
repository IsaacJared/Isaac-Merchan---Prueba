using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorCanasta : MonoBehaviour
{
    private float speed = 8.0f;
    private float horizontalInput;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
