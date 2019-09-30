using System;

namespace TreehouseDefense
{
  class SuperTower : Tower
  {
    protected override int Power { get; } = 2;
    protected override int Range { get; } = 3;
    protected override double Accuracy { get; } = 1.0;

    public SuperTower(MapLocation location) : base(location)
    {
    }

  }
}
