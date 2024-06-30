using UnityEngine;

namespace Weapon
{
    public class Gun : MonoBehaviour, IWeapon
    {
        public void PerformAttack() =>
            Debug.Log("bang");
    }
}