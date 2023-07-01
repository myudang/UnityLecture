using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject platform;

    void Start()
    {
        // Instantiate : 게임 오브젝트를 생성하는 함수
        // 첫 번째 매개변수 : 생성하고 싶은 게임 오브젝트
        // 두 번째 매개변수 : 게임 오브젝트의 위치
        // 세 번째 매개변수 : 게임 오브젝트의 회전

        Instantiate
        (
            platform,
            transform.position,
            Quaternion.identity
        );
    }
}
