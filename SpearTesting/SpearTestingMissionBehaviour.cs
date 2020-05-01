using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.MountAndBlade.ComponentInterfaces;

namespace SpearTesting
{
    public class SpearTestingMissionBehaviour : MissionLogic
    {
        public override void OnScoreHit(Agent affectedAgent, Agent affectorAgent, int affectorWeaponKind, bool isBlocked, float damage, float movementSpeedDamageModifier, float hitDistance, AgentAttackType attackType, float shotDifficulty, int weaponCurrentUsageIndex)
        {
            // If any of the agents are null, we do nothing
            if (affectedAgent == null || affectorAgent == null)
                return;

            // Deal a minimum of 10.0f damage
            if (affectedAgent.IsMount && !isBlocked || affectedAgent.IsHuman && affectedAgent.HasMount && !isBlocked)
                damage = (damage < 10.0f) ? 10.0f : damage;

            // Hit Agent is a Horse
            if(affectedAgent.IsMount && !affectedAgent.IsHuman)
            {
                ItemObject weaponItem = ItemObject.GetItemFromWeaponKind(affectorWeaponKind);
                if (weaponItem == null)
                    return;

                WeaponType weaponType = WeaponManager.GetWeaponType(weaponItem.StringId).Value;
                switch (weaponType)
                {
                    case WeaponType.Spear:
                        if (movementSpeedDamageModifier > 0.1f && movementSpeedDamageModifier < 1.00f)
                        {
                            affectedAgent.Health = affectedAgent.Health - (damage * (movementSpeedDamageModifier * 2.50f));
                        } else if (movementSpeedDamageModifier > 1.00f) {
                            affectedAgent.Health = affectedAgent.Health - (damage * (movementSpeedDamageModifier * 5.00f));
                        }
                        break;
                    case WeaponType.Pike:
                        // Do Stuff Here
                        break;
                    case WeaponType.Lance:
                        // Do Stuff Here
                        break;
                    case WeaponType.ThrowingSpear:
                        // Do Stuff Here
                        break;
                    case WeaponType.Javelin:
                        // Do Stuff Here
                        break;
                    default:
                        // Do Stuff Here
                        break;
                }
            }

            // Hit Agent is a Rider (if they lose their horse, we should stop dealing bonus damage)
            if(affectedAgent.IsHuman && affectedAgent.HasMount)
            {
                ItemObject weaponItem = ItemObject.GetItemFromWeaponKind(affectorWeaponKind);
                if (weaponItem == null)
                    return;

                WeaponType weaponType = WeaponManager.GetWeaponType(weaponItem.StringId).Value;
                switch (weaponType)
                {
                    case WeaponType.Spear:
                        if (movementSpeedDamageModifier > 0.1f && movementSpeedDamageModifier < 1.00f)
                        {
                            affectedAgent.Health = affectedAgent.Health - (damage * (movementSpeedDamageModifier * 2.00f));
                        } else if (movementSpeedDamageModifier > 1.00f) {
                            affectedAgent.Health = affectedAgent.Health - (damage * (movementSpeedDamageModifier * 3.00f));
                        }
                        break;
                    case WeaponType.Pike:
                        // Do Stuff Here
                        break;
                    case WeaponType.Lance:
                        // Do Stuff Here
                        break;
                    case WeaponType.ThrowingSpear:
                        // Do Stuff Here
                        break;
                    case WeaponType.Javelin:
                        // Do Stuff Here
                        break;
                    default:
                        // Do Stuff Here
                        break;
                }
            }

            // Hit Agent is Infantry
            if (affectedAgent.IsHuman && !affectedAgent.HasMount)
            {
                ItemObject weaponItem = ItemObject.GetItemFromWeaponKind(affectorWeaponKind);
                if (weaponItem == null)
                    return;

                WeaponType weaponType = WeaponManager.GetWeaponType(weaponItem.StringId).Value;
                switch (weaponType)
                {
                    case WeaponType.Spear:
                        // Do Stuff Here
                        break;
                    case WeaponType.Pike:
                        // Do Stuff Here
                        break;
                    case WeaponType.Lance:
                        // Do Stuff Here
                        break;
                    case WeaponType.ThrowingSpear:
                        // Do Stuff Here
                        break;
                    case WeaponType.Javelin:
                        // Do Stuff Here
                        break;
                    default:
                        // Do Stuff Here
                        break;
                }
            }
        }

        #region Utility Methods
        public void DisplayMessage(string message)
        {
            InformationManager.DisplayMessage(new InformationMessage(message));
        }

        public void DisplayMessage(string message, string hexColour)
        {
            InformationManager.DisplayMessage(new InformationMessage(message, Color.ConvertStringToColor(hexColour+"FF")));
        }
        #endregion
    }
}
