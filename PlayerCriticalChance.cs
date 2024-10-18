using System;

namespace GameplayLibrary
{
    namespace CalculateChance
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

            /// <summary>
            /// If randomNumber is >= chance, this returns true, else it will return false
            /// </summary>
            /// <param name="randomNumber"></param>
            /// <param name="chance"></param>
            /// <returns></returns>
            public static bool CheckForChance(int randomNumber, int chance)
            {
                if (randomNumber >= chance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            /// <summary>
            /// If the boolChance parameter is true, this returns baseNumber multipled by the multiplier,
            /// otherwise it returns just the baseNumber
            /// </summary>
            /// <param name="boolChance"></param>
            /// <param name="baseNumber"></param>
            /// <param name="multiplier"></param>
            /// <returns></returns>
            public static float GiveNumberMultipliedIfBoolTrue(bool boolChance, float baseNumber, float multiplier)
            {
                if (boolChance == true)
                {
                    return baseNumber * multiplier;
                }
                else
                {
                    return baseNumber;
                }
            }
        }
    }

    namespace ChangingLevels
    {
        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;
        using UnityEngine.SceneManagement;
        using UnityEngine.UI;
        public class ChangeScenes: MonoBehaviour
        {
            /// <summary>
            /// Will change scene while having a load screen with a loading bar
            /// </summary>
            /// <param name="scene">The name/string of the scene to load from the build index</param>
            /// <param name="loadScreen">A load screen that activates while loading the scene</param>
            /// <param name="loadingBar">A loading bar that shows the loading progress of the scene to load</param>
            /// <returns></returns>
            public IEnumerator LevelChangeWithLoadingScreen(string scene, GameObject loadScreen, Slider loadingBar)
            {
                AsyncOperation operation = SceneManager.LoadSceneAsync(scene);
                loadScreen.SetActive(true);

                while (!operation.isDone)
                {
                    float loadProgress = Mathf.Clamp01(operation.progress/0.9f);
                    loadingBar.value = loadProgress;
                    yield return null;
                }               
            }

            /// <summary>
            /// Will change scene while having a load screen with a loading bar
            /// </summary>
            /// <param name="scene">The number of the scene to load from the build index</param>
            /// <param name="loadScreen">A load screen that activates while loading the scene</param>
            /// <param name="loadingBar">A loading bar that shows the loading progress of the scene to load</param>
            /// <returns></returns>
            public IEnumerator LevelChangeWithLoadingScreen(int scene, GameObject loadScreen, Slider loadingBar)
            {
                AsyncOperation operation = SceneManager.LoadSceneAsync(scene);
                loadScreen.SetActive(true);

                while (!operation.isDone)
                {
                    float loadProgress = Mathf.Clamp01(operation.progress / 0.9f);
                    loadingBar.value = loadProgress;
                    yield return null;
                }
            }          
        }    
    }
}
