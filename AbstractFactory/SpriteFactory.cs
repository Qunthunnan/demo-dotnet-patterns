using System;

namespace AbstractFactory
{
    class SpriteFactory : AbstractFactory
    {
        // реализация метода порождения экземпляра класса AbstractWater:
        // вернуть экземпляр дочернего класса SpriteWater
        public override AbstractWater CreateWater()
        {
            return new SpriteWater();
        }

        // реализация метода порождения экземпляра класса AbstractBottle:
        // вернуть экземпляр дочернего класса SpriteBottle
        public override AbstractBottle CreateBottle()
        {
            return new SpriteBottle();
        }
    }
}
