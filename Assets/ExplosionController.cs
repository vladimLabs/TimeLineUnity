using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public float delay = 3.0f; // Задержка в секундах перед взрывом
    public ParticleSystem[] explosionEffect;

    void Start()
    {
        // Запускаем корутину для взрыва с задержкой
        StartCoroutine(TriggerExplosion());
    }

    IEnumerator TriggerExplosion()
    {
        // Ждем указанное количество секунд
        yield return new WaitForSeconds(delay);

        // Активируем эффект взрыва
        foreach (var explosion in explosionEffect)
        {
            explosion.Play();
        }
    }
}
