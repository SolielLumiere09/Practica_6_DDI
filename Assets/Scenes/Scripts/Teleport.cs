using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject player;
    private Transform _transform;
    private Vector3 _offset;
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = new Vector3(0, 2, 0);
        _transform = GetComponent<Transform>();
        
    }

    public void teleport()
    {
        player.transform.position = _transform.position + _offset;
        Debug.Log("Moved");
    }


}
