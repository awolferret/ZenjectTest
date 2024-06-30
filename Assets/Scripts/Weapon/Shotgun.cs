using UnityEngine;

namespace Weapon
{
    public class Shotgun : MonoBehaviour, IWeapon
    {
        [SerializeField] private int _amountFraction;

        public void PerformAttack()
        {
            for (int i = 0; i < _amountFraction; i++)
                Debug.Log("attack");
        }
    }
}