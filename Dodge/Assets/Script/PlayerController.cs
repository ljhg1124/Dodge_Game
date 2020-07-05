using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;   // 이동에 사용될 rigidbody 컴포넌트.
    public float speed = 8f;    // 이동 속력.

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal"); // 수평축 입력값 감지.
        float zInput = Input.GetAxis("Vertical");   // 수직축 입력값 감지.

        // 실제 이동 속도를 입력값과 이동 속력을 사용해 결정.
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, ySpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // 리지드바디의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;

        /*
        // 위쪽 방향키 입력이 감지된 경우 z축 방향 힘 주기
        if (Input.GetKey(KeyCode.UpArrow)) playerRigidbody.AddForce(0f, 0f, speed);

        // 아래쪽 방향키 입력이 감지된 경우 -z축 방향 힘 주기
        if (Input.GetKey(KeyCode.DownArrow)) playerRigidbody.AddForce(0f, 0f, -speed);

        // 오른쪽 방향키 입력이 감지된 경우 x축 방향 힘 주기
        if (Input.GetKey(KeyCode.RightArrow)) playerRigidbody.AddForce(speed, 0f, 0f);

        // 왼쪽 방향키 입력이 감지된 경우 -x축 방향 힘 주기
        if (Input.GetKey(KeyCode.LeftArrow)) playerRigidbody.AddForce(-speed, 0f, 0f);
        */
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
