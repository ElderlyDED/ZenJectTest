using UnityEngine;
using Zenject;

public class PlayerMonoInstaller : MonoInstaller
{
    [SerializeField] private PlayerScript script;
    public override void InstallBindings()
    {
        Container.Bind<PlayerScript>().FromInstance(script).AsSingle().NonLazy();
    }
}