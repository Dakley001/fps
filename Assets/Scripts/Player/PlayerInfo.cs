using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI playerName;
    [SerializeField]
    private Transform playerHealth;
    [SerializeField]
    private Transform infoUI;

    private Player player;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        playerName.text = transform.name;
        playerHealth.localScale = new Vector3(player.GetHealth() / 100f, 1f, 1f);

        var camera = Camera.main;
        infoUI.transform.LookAt(infoUI.transform.position + camera.transform.rotation * Vector3.back, camera.transform.rotation * Vector3.up);
        infoUI.Rotate(new Vector3(0f, 180f, 0f));
    }
}
