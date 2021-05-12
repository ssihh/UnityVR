using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    // Start is called before the first frame update
    [SerializeField] ParticleSystem hitParticlePrefab;
    void Start()
    {
        // �ӷ�
        var velocity = speed * transform.forward;

        // �ӵ�
        var rigidbody = GetComponent<Rigidbody>();

        // ������ �ӵ��� ���� ���ϴ� �Լ�, ������ ���ư��� �����
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
        
    }

    private void OnTriggerEnter(Collider other) //�Ѿ˿� Ʈ���Ű� ������
    {
        other.SendMessage("OnHitBullet"); //Enemy.cs�� �޽����� ����
        Instantiate(hitParticlePrefab, transform.position, transform.rotation);
        Destroy(gameObject);//Ŭ���̴� ���� ���� �� ȣ��
        // Rigidbody �ݶ��̴� <-> Kinematic Rigidbody Ʈ���� �ݶ��̴�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
