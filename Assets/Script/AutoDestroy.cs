using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeOut;

    void Start()
    {
        Destroy (gameObject, timeOut);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
