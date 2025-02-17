using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public static PlayerUI Singleton;

    private Player player = null;

    [SerializeField]
    private TextMeshProUGUI bulletsText;
    [SerializeField]
    private GameObject bulletsObject;

    private WeaponManager weaponManager;

    [SerializeField]
    private Transform healthBarFill;
    [SerializeField]
    private GameObject healthBarObject;

    private void Awake()
    {
        Singleton = this;
    }

    public void setPlayer(Player localPlayer)
    {
        player = localPlayer;
        weaponManager = player.GetComponent<WeaponManager>();
        bulletsObject.SetActive(true);
        healthBarObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        var currentWeapon = weaponManager.GetCurrentWeapon();
        if (currentWeapon.isReloading)
        {
            bulletsText.text = "Reloading...";
        }
        else
        {
            bulletsText.text = "Bullets: " + currentWeapon.bullets + "/" + currentWeapon.maxBullets;
        }

        healthBarFill.localScale = new Vector3(player.GetHealth() / 100f, 1f, 1f);
    }
}
