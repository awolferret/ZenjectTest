using UnityEngine;

namespace Weapon
{
    public class Sword : MonoBehaviour, IWeapon
    {
        public void PerformAttack() =>
            Debug.Log("slash");
    }
}