using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnergyBarUI : MonoBehaviour
{
    public PlayerEnergy playerEnergy; 
    public Slider energySlider;

    void Start()
    {
        if (playerEnergy == null)
            playerEnergy = FindObjectOfType<PlayerEnergy>();

        energySlider.maxValue = playerEnergy.maxEnergy;
        energySlider.value = playerEnergy.currentEnergy;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        playerEnergy = FindObjectOfType<PlayerEnergy>();
        energySlider.maxValue = playerEnergy.maxEnergy;
        energySlider.value = playerEnergy.currentEnergy;
    }

    void Update()
    {
        if(playerEnergy != null)
            energySlider.value = playerEnergy.currentEnergy;
    }
}
