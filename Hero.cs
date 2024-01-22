
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hero {

    public Hero() {
    }

    public HashSet<Protection> Protections;

    public Arsenal HeroArsenal;

    public int m_iLifePoints;

    public Weapon ActiveWeapon;




    public void SelectProtection() {
        // TODO implement here
    }

    /// <summary>
    /// @param RoomMonster
    /// </summary>
    public void AutoSelectCorrectProtection(Monster RoomMonster) {
        // TODO implement here
    }

    /// <summary>
    /// @param p_Monster 
    /// @return
    /// </summary>
    public void Attack(Monster p_Monster) {
        // TODO implement here
    }

    /// <summary>
    /// @param p_Monster
    /// </summary>
    public void CheckProtectionEfficiency(Monster p_Monster) {
        // TODO implement here
    }

    public void GettingHit() {
        // TODO implement here
    }

    public void OpenChest(Chest p_Chest) {
        // TODO implement here
    }

}