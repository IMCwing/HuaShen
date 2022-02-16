using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrevious : MonoBehaviour
{

        

    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindWithTag("Middle");
        if (obj != null)
        {
            Destroy(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
