using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpearTesting
{
    public enum WeaponType
    {
        Spear = 0,
        Pike = 1,
        Lance = 2,
        ThrowingSpear = 3,
        Javelin = 4,
        Other = 5
    }

    public static class WeaponManager
    {
        static readonly Dictionary<string, WeaponType> _weaponList = new Dictionary<string, WeaponType>(){
            // Spears
            {"western_spear_1_t2", WeaponType.Spear},
            {"western_spear_2_t2", WeaponType.Spear},
            {"western_spear_3_t3", WeaponType.Spear},
            {"western_spear_4_t4", WeaponType.Spear},
            {"eastern_spear_1_t2", WeaponType.Spear},
            {"eastern_spear_2_t3", WeaponType.Spear},
            {"eastern_spear_3_t3", WeaponType.Spear},
            {"eastern_spear_4_t4", WeaponType.Spear},
            {"eastern_spear_5_t5", WeaponType.Spear},
            {"northern_spear_1_t2", WeaponType.Spear},
            {"northern_spear_2_t3", WeaponType.Spear},
            {"northern_spear_3_t4", WeaponType.Spear},
            {"northern_spear_4_t5", WeaponType.Spear},
            {"imperial_spear_t2", WeaponType.Spear},
            {"triangular_spear_t3", WeaponType.Spear},
            {"wide_leaf_spear_t4", WeaponType.Spear},
            // Pikes
            {"simple_pike_t2", WeaponType.Pike},
            {"military_form_pike_t3", WeaponType.Pike},
            {"thamaskene_pike_t4", WeaponType.Pike},
            {"fine_pike_t4", WeaponType.Pike},
            {"vlandia_pike_1_t5", WeaponType.Pike},
            // Lances
            {"vlandia_lance_1_t3", WeaponType.Lance},
            {"empire_lance_1_t3", WeaponType.Lance},
            {"khuzait_lance_1_t3", WeaponType.Lance},
            {"aserai_lance_1_t5", WeaponType.Lance},
            {"vlandia_lance_2_t4", WeaponType.Lance},
            {"empire_lance_2_t4", WeaponType.Lance},
            {"sturgia_lance_1_t4", WeaponType.Lance},
            {"khuzait_lance_2_t4", WeaponType.Lance},
            {"vlandia_lance_3_t5", WeaponType.Lance},
            {"sturgia_lance_2_t5", WeaponType.Lance},
            {"empire_lance_3_t5", WeaponType.Lance},
            {"khuzait_lance_3_t5", WeaponType.Lance},
            // Throwing Spears
            {"eastern_throwing_spear_1_t3", WeaponType.ThrowingSpear},
            {"eastern_throwing_spear_2_t4", WeaponType.ThrowingSpear},
            {"imperial_throwing_spear_1_t4", WeaponType.ThrowingSpear},
            // Javelins
            {"western_javelin_1_t2", WeaponType.Javelin},
            {"northern_javelin_1_t2", WeaponType.Javelin},
            {"eastern_javelin_1_t2", WeaponType.Javelin},
            {"western_javelin_2_t3", WeaponType.Javelin},
            {"generic_javelin_1_t3", WeaponType.Javelin},
            {"northern_javelin_2_t3", WeaponType.Javelin},
            {"eastern_javelin_2_t3", WeaponType.Javelin},
            {"western_javelin_3_t4", WeaponType.Javelin},
            {"northern_javelin_3_t4", WeaponType.Javelin},
            {"eastern_javelin_3_t4", WeaponType.Javelin}
        };

        public static WeaponType? GetWeaponType(string weaponId)
        {
            if(!string.IsNullOrWhiteSpace(weaponId))
            {
                WeaponType weaponType;

                if (!_weaponList.TryGetValue(weaponId, out weaponType))
                    return WeaponType.Other;

                return weaponType;

            }
            return null;
        }
    }
}
