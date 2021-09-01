using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }
}
