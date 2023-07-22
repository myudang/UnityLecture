    using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager instance;
    
    [SerializeField] GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    [SerializeField] int prefabCount = 5;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        for (int i = 0; i < prefabCount; i++)
        {
            // 1. ���� ������Ʈ�� �����մϴ�.
            GameObject prefabObject = Instantiate(prefab, Vector3.zero, Quaternion.identity);

            // 2. ������ ���� ������Ʈ�� ������� Queue �����̳ʿ� �����մϴ�.
            queue.Enqueue(prefabObject);

            // 3. ���� ������Ʈ�� ��Ȱ��ȭ�մϴ�.
            prefabObject.SetActive(false);
        }
    }

    void Start()
    {
        
    }

    // Queue�� �����͸� �־��ִ� �Լ�
    public void InsertQueue(GameObject insertObject)
    {
        insertObject.transform.position = Vector3.zero;

        queue.Enqueue(insertObject);
        insertObject.SetActive(false);
    }

    // Queue���� ������ �Լ�
    public void GetQueue()
    {
        GameObject tempObject = queue.Dequeue();
        tempObject.SetActive(true);
    }
}
