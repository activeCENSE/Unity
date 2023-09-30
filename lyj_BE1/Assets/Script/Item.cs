using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float rotateSpeed;

    void Update()
    {
        //월드 좌표계를 중심으로 회전하게 해줌(Space.World)
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }

    
}
