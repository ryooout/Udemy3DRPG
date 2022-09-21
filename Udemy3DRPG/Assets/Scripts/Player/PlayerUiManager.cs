using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//DoTweenを使用するための宣言
using DG.Tweening;
public class PlayerUiManager : MonoBehaviour
{
    //Hpゲージ
    public Slider hpSlider;
    //スタミナゲージ
    public Slider staminaSlider;
    /// <summary>
    /// MaxのHpを設定
    /// </summary>
    /// <param name="playerManager"></param>
    public void Init(PlayerManager playerManager)
    {
        hpSlider.maxValue = playerManager.maxHp;
        hpSlider.value = playerManager.maxHp;
        staminaSlider.maxValue = playerManager.maxStamina;
        staminaSlider.value = playerManager.maxStamina;
    }
    /// <summary>DoTweenを用いたHpの減少</summary>
    public void UpdateHp(int hp)
    {
        hpSlider.DOValue(hp, 0.5f);
    }
    /// <summary>DoTweenを用いたスタミナの減少</summary>
    public void UpdateStamina(int sutamina)
    {
        staminaSlider.DOValue(sutamina, 0.5f);
    }
}
