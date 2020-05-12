
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    AudioSource m_shootingSound;

    void Start()
    {
        m_shootingSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            m_shootingSound.Play();
            Shoot();
        }
    }

    void Shoot()
    {

        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
