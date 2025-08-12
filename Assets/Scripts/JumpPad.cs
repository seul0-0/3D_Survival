using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class JumpPad : MonoBehaviour
{
    [Header("Jump Settings")]
    public float impulse = 12f;          // 위로 가할 힘(질량의 영향 받음)

    private void OnCollisionEnter(Collision other)
    {
        // Player만 작동 (플레이어에 Tag=Player 설정 권장)
        if (!other.gameObject.CompareTag("Player")) return;
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * impulse, ForceMode.Impulse);
    }
}