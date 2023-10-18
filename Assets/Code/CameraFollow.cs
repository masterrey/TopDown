using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField]
    float speed = 1;
    [SerializeField]
    float distance = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPos = new Vector3(target.transform.position.x, target.transform.position.y,-distance);
        transform.position= Vector3.Lerp(transform.position, targetPos, Time.smoothDeltaTime* speed);
        
    }
    
}
