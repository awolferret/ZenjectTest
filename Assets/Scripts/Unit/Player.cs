using UnityEngine;
using Weapon;
using Zenject;

namespace Unit
{
    public class Player : MonoBehaviour, IUnit
    {
        private IWeapon _weapon;
        
        [Inject]
        public void Construct(Gun weapon) => 
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