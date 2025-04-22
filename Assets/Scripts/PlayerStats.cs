using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int coins = 10;
    public int health = 100;
    public int strength = 20;

    public TMP_Text coinsText;
    public TMP_Text healthText;
    public TMP_Text strengthText;

    void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Add":
                coins += 5;
                break;
            case "Subtract":
                health -= 20;
                break;
            case "Multiply":
                strength *= 2;
                break;
            case "Divide":
                coins /= 2;
                break;
            case "Mod":
                health %= 33;
                break;
            case "Reset":
                coins = 10;
                health = 100;
                strength = 20;
                break;
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        coinsText.text = "Coins: " + coins;
        healthText.text = "Health: " + health;
        strengthText.text = "Strength: " + strength;
    }
}
