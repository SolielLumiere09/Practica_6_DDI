using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform cameraTransform;
    public Transform playerTransform;
    public float moveSpeed;
    
    // Start is called before the first frame updat
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(1))
            playerTransform.Translate(cameraTransform.forward.normalized * moveSpeed * Time.deltaTime);

    }
}
