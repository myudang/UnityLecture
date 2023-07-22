using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] float speed = 1.0f;

    void Update()
    {
        direction = new Vector2(0.1f, 0);

        transform.position -= (Vector3)direction * speed * Time.deltaTime;
    }

    // OnTriggerEnter2D : Trigger�� �浹�ߴٸ�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ť�� ��ȯ�մϴ�.
        ObjectPoolManager.instance.InsertQueue(gameObject);
    }
}
