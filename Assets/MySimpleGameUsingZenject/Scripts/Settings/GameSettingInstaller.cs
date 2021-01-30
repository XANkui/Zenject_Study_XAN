using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    [CreateAssetMenu(fileName = "GameSettingInstaller", menuName = "Installers/GameSettingInstaller")]
    public class GameSettingInstaller : ScriptableObjectInstaller<GameSettingInstaller>
    {
        public PlayerController.Setting PlayerControllerSetting;
        public NPCController.Setting EnemyControllerSetting;
        public override void InstallBindings()
        {
            Container.BindInstance(PlayerControllerSetting);
            Container.BindInstance(EnemyControllerSetting);
        }
    }
}