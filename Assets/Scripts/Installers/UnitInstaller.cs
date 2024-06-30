using UnityEngine;
using Weapon;
using Zenject;

namespace Installers
{
    public class UnitInstaller : MonoInstaller
    {
        [SerializeField] private Shotgun _shotgun;
        [SerializeField] private Gun _gun;
        [SerializeField] private Sword _sword;

        public override void InstallBindings()
        {
            Container.Bind<Sword>().FromInstance(_sword);
            Container.Bind<Gun>().FromInstance(_gun);
            Container.Bind<Shotgun>().FromInstance(_shotgun);
        }
    }
}
