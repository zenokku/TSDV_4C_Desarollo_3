using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_T : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private float _speed;
    [SerializeField] private string _enemyTag = "Enemy";
    [SerializeField] private string _playerTag = "Player";
    #endregion

    #region PRIVATE_FIELDS
    private Rigidbody _rb;
    #endregion

    #region UNITY_CALLS
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = transform.forward * _speed;

        Destroy(gameObject, 2.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == _enemyTag || collision.collider.tag == _playerTag)
            Destroy(gameObject);
    }
    #endregion
}
