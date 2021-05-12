using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunBarrelEnd; //�ѱ�

    [SerializeField] ParticleSystem gunParticle;

    [SerializeField] AudioSource GunAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) //���콺 ��ư�� ������
        {
            Shoot();
        }
    }
     
    void Shoot()
    {
        //�ʾ��� ��������, �ν�źƼ����Ʈ
        Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);
        gunParticle.Play();
        GunAudioSource.Play();
    }
}
