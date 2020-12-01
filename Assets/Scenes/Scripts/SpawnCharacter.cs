using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{

    public GameObject character;

    public float timeElapsed = 0;
    public float waitTimeSpawn = 5;
    public Boolean isFocusSet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFocusSet)
            timeElapsed += Time.deltaTime;

        if (timeElapsed > waitTimeSpawn)
        {
            character.SetActive(true);
            timeElapsed = 0;

        }

    }


    public void setFocus(Boolean flag)
    {
        isFocusSet = flag;

    }

    public void exitFocus()
    {
        character.SetActive(false);
        setFocus(false);
        timeElapsed = 0;
    }
}
