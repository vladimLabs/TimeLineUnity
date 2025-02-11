using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public float delay = 3.0f; // �������� � �������� ����� �������
    public ParticleSystem[] explosionEffect;

    void Start()
    {
        // ��������� �������� ��� ������ � ���������
        StartCoroutine(TriggerExplosion());
    }

    IEnumerator TriggerExplosion()
    {
        // ���� ��������� ���������� ������
        yield return new WaitForSeconds(delay);

        // ���������� ������ ������
        foreach (var explosion in explosionEffect)
        {
            explosion.Play();
        }
    }
}
