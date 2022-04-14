using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private BulletShooterBehavior _gun;
    private float _bulletCount;
    [SerializeField]
    private float _bulletCooldown;
    private float _bulletTimer;
    [SerializeField]
    private int _ammo = 0;
    [SerializeField]
    private bool _infiniteAmmo = true;

    public bool CheckHasAmmo()
    {
        if (_infiniteAmmo) return true;

        return _ammo > 0;
    }

    private void Awake()
    {
        CheckHasAmmo();
    }

}
