namespace TreehouseDefense
{
  class Level
  {
    private readonly IInvader[] _invaders;

    public Tower[] Towers { get; set; }

    public Level(IInvader[] invaders)
    {
      _invaders = invaders;
    }

    // Returns true if the player wins false otherwise
    public bool Play()
    {
      int remainingInvaders = _invaders.Length;

      while(remainingInvaders > 0)
      {
        foreach (Tower tower in Towers)
        {
          tower.FireOnInvaders(_invaders);
        }

        remainingInvaders = 0;
        foreach (IInvader invader in _invaders)
        {
          if(invader.IsActive)
          {
            invader.Move();

            if(invader.HasScored)
            {
              return false;
            }
            remainingInvaders++;
          }
        }
      }
      return true;
    }
  }
}