using TaleWorlds.MountAndBlade;
using TaleWorlds.MountAndBlade.MissionSpawnHandlers;

namespace SpearTesting
{
    public class SubModule : MBSubModuleBase
    {
        public override void OnMissionBehaviourInitialize(Mission mission)
        {
            // TODO: Add to more missions such as tournament

            // Field Battle
            if (mission.HasMissionBehaviour<FieldBattleController>())
                mission.AddMissionBehaviour(new SpearTestingMissionBehaviour());

            // Custom Battle
            if (mission.HasMissionBehaviour<CustomBattleMissionSpawnHandler>())
                mission.AddMissionBehaviour(new SpearTestingMissionBehaviour());
        }
    }
}