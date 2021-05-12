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
        // 속력
        var velocity = speed * transform.forward;

        // 속도
        var rigidbody = GetComponent<Rigidbody>();

        // 지정한 속도로 힘을 가하는 함수, 앞으로 날아가게 만들기
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
        
    }

    private void OnTriggerEnter(Collider other) //총알에 트리거가 들어갔을때
    {
        other.SendMessage("OnHitBullet"); //Enemy.cs에 메시지를 보냄
        Instantiate(hitParticlePrefab, transform.position, transform.rotation);
        Destroy(gameObject);//클라이더 끼리 닿을 때 호출
        // Rigidbody 콜라이더 <-> Kinematic Rigidbody 트리거 콜라이더
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
