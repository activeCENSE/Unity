using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset;

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    //UI 업데이트, 카메라 업데이트, 카메라 이동 등은 여기에서 이루어짐
    //Update에서 연산을 다 하고 뒤에 따라 붙는 거기 때문에,,,
    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
