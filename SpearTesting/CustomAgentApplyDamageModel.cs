using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.MountAndBlade.ComponentInterfaces;

namespace SpearTesting
{
    public class CustomAgentApplyDamageModel : AgentApplyDamageModel
    {
        // TODO: Migrate to using a custom damage model instead
        public override float CalculateCouchedLanceDamage(BasicCharacterObject attackerCharacter, float baseDamage)
        {
            throw new NotImplementedException();
        }

        public override int CalculateDamage(BasicCharacterObject affectorCharacterBasic, BasicCharacterObject affectedCharacterBasic, MissionWeapon offHandItem, bool isHeadShot, bool isAffectedAgentMount, bool isAffectedAgentHuman, bool hasAffectorAgentMount, bool isAffectedAgentNull, bool isAffectorAgentHuman, AttackCollisionData collisionData, WeaponComponentData weapon)
        {
            throw new NotImplementedException();
        }

        public override void CalculateEffects(Agent attackerAgent, ref bool crushedThrough)
        {
            throw new NotImplementedException();
        }

        public override float CalculateMoraleEffects(Agent attackerAgent, Agent defenderAgent, int weaponCurrentUsageIndex, int affectorWeaponKind)
        {
            throw new NotImplementedException();
        }

        public override float CalculateShieldDamage(float baseDamage)
        {
            throw new NotImplementedException();
        }
    }
}
