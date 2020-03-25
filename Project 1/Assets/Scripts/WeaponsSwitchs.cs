using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponsSwitchs : MonoBehaviour
{
    public UnityEvent knifeEvent, pistolEvent, rifleEvent, machineGunEvent, grenadeEvent, shotgunEvent;
    public enum Weapons
    {
        Knife,
        Pistol,
        Rifle,
        MachineGun,
        Grenade,
        Shotgun
    }

    public Weapons currentWeapons;
    void Update()
    {
        switch (currentWeapons)
        {
            case Weapons.Knife:
                knifeEvent.Invoke();
                break;
            case Weapons.Pistol:
                pistolEvent.Invoke();
                break;
            case Weapons.Rifle:
                rifleEvent.Invoke();
                break;
            case Weapons.MachineGun:
                machineGunEvent.Invoke();
                break;
            case Weapons.Grenade:
                grenadeEvent.Invoke();
                break;
            case Weapons.Shotgun:
                shotgunEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
