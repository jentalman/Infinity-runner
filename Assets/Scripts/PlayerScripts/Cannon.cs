using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private CannonBallSpawner _spawner;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryShoot();
        }
    }

    private void TryShoot()
    {
            if (TryGetObjectFromPool(out GameObject cannonBall))
            {
                Shoot(cannonBall, _cannonBallSpawnPoint.position);
            }
    }

    private void Shoot(GameObject cannonBall, Vector3 SpawnPoint)
    {
        cannonBall.SetActive(true);
        cannonBall.transform.position = SpawnPoint;
        cannonBall.transform.Translate(Vector2.right * Time.deltaTime);
    }
}
