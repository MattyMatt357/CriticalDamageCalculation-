using System;

namespace CalculateDamage
{
    public class PlayerCriticalChance 
    {
        /// <summary>
        /// Calculates the chance of dealing critical or normal damage
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="critChance"></param>
        /// <param name="baseDamage"></param>
        /// <param name="damageMultiplier"></param>
        /// <returns></returns>
        public static float WeaponDamageChance(int randomNum, int critChance, float baseDamage, float damageMultiplier)
        {
            if (randomNum >= critChance)
            {
                return baseDamage * damageMultiplier;
            }
            else 
            {
                return baseDamage;
            }
        }

        
    }
}
