using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunBarrelEnd; //총구

    [SerializeField] ParticleSystem gunParticle;

    [SerializeField] AudioSource GunAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) //마우스 버튼을 누르면
        {
            Shoot();
        }
    }
     
    void Shoot()
    {
        //초알을 복제해줌, 인스탄티에이트
        Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);
        gunParticle.Play();
        GunAudioSource.Play();
    }
}
