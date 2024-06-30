using System;
using UnityEngine;
using Weapon;
using Zenject;

namespace Unit
{
    public class EnemySkeleton : MonoBehaviour, IUnit
    {
        private IWeapon _weapon;

        [Inject]
        public void Construct(Sword weapon) =>
            _weapon = weapon;

        private void Start() =>
            PerformAttack();

        public void PerformAttack()
        {
            Debug.Log(gameObject.name + " " + _weapon);
            _weapon.PerformAttack();
        }
    }
}