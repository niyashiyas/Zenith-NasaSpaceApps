using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    static public GameObject target; // the target that the camera should look at
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (target)
            transform.LookAt(target.transform);
    }
}
