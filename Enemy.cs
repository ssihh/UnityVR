using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip;
    [SerializeField] AudioClip hitClip;

    [SerializeField] Collider enemyCollider;
    [SerializeField] Renderer enemyRenderer;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.PlayOneShot(spawnClip);
    }
    
    void OnHitBullet() // Bullet.cs ���� ȣ��Ǵ� �Լ�
    {
        audioSource.PlayOneShot(hitClip);

        enemyCollider.enabled = false;
        enemyRenderer.enabled = false;

        Destroy(gameObject, 1f); //1��, �Ҹ������ ����
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
