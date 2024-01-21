using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclaT : MonoBehaviour
{
    // Start is called before the first frame update
    public float min = -10f;
    public float max = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.position = new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        }
    }
}
