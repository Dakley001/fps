using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerWeapon
{
    public string name = "M16A1";
    public int damage = 5;
    public float range = 100f;

    public float shootRate = 10f;  // 一秒可以打多少发子弹。如果小于等于0，则为单发
    public float shootCoolDownTime = 0.75f;  // 单发模式的冷却时间
    public float recoilForce = 2f;  // 后坐力

    public GameObject graphics;
}