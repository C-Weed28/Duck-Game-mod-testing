using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DuckGame;
// The title of your mod, as displayed in menus
[assembly: AssemblyTitle("AKBazooka")]

// The author of the mod
[assembly: AssemblyCompany("C-Weed")]

// The description of the mod
[assembly: AssemblyDescription("Combination of an AK and a bazooka")]

// The mod's version
[assembly: AssemblyVersion("1.0.0.0")]

namespace DuckGame.MyMod
{
    public class AK47 : Gun {
        public AK47(float xval, float yval)
            : base(xval, yval)
        {
            ammo = 30;
            _ammoType = new ATMissile();
            _ammoType.range = 200f;
            _ammoType.accuracy = 0.85f;
            _ammoType.penetration = 2f;
            _type = "gun";
            graphic = new Sprite("contents/AKBazooka", 0f, 0f);
            center = new Vec2(16f, 15f);
            collisionOffset = new Vec2(-8f, -3f);
            collisionSize = new Vec2(18f, 10f);
            _barrelOffsetTL = new Vec2(32f, 14f);
            _fireSound = "deepMachineGun2";
            _fullAuto = true;
            _fireWait = 1.2f;
             _kickForce = 3.5f;
            loseAccuracy = 0.2f;
            maxAccuracyLost = 0.8f;
        }
    }


    }
