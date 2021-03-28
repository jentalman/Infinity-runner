using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private CannonBallSpawner _spawner;
    [SerializeField] private Transform _cannonBallSpawnPoint;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _force;
    [SerializeField] private float _reloadTime;

    private bool _cannonLoaded = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryShoot();
        }
    }

    private void TryShoot()
    {
        if (_spawner.TryGetObjectFromPool(out GameObject cannonBall) && _cannonLoaded == true)
        {
            Shoot(cannonBall, _cannonBallSpawnPoint.position);
            _cannonLoaded = false;
            StartCoroutine(Reload());
        }
    }

    private void Shoot(GameObject cannonBall, Vector3 SpawnPoint)
    {
        _animator.SetTrigger("Shoot");
        cannonBall.SetActive(true);
        cannonBall.transform.position = SpawnPoint;
        CannonBall ball = cannonBall.GetComponent<CannonBall>();
        ball.SetImpulse(Vector2.right, _force);
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(_reloadTime);
        _cannonLoaded = true;
        yield break;
    }
}
