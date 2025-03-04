using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  private Rigidbody targetRb;
  private float minSpeed = 12;
  private float maxSpeed = 16;
  private float maxTorque = 10;
  private float Range = 4;
  private float ySpawnPos = -2;
  public int pointValue;
  public ParticleSystem explosionParticle;
  void Start()
  {
    targetRb = GetComponent<Rigidbody>();

    targetRb.AddForce(RandomForcel(), ForceMode.Impulse);
    targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
    transform.position = RandomSpawnPos();
  }
  Vector3 RandomForcel()
  {
    return Vector3.up * Random.Range(minSpeed, maxSpeed);
  }
  float RandomTorque()
  {
    return Random.Range(-maxTorque, maxTorque);
  }
  Vector3 RandomSpawnPos()
  {
    return new Vector3(Random.Range(-Range, Range), ySpawnPos);
  }

  private void OnMouseDown()
  {
    if (GameManager.Instance.isGameActive)
    {
      Destroy(gameObject);
      Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
      GameManager.Instance.UpdateScore(pointValue);

    }
  }

  private void OnTriggerEnter(Collider other)
  {
    Destroy(gameObject);
    if (!gameObject.CompareTag("Bad"))
    {
      GameManager.Instance.GameOver();
    }
  }
}