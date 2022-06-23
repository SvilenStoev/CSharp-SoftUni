using Skeleton.Contracts;
using System;

public class Dummy : ITarget
{
    private int health;
    private int experience;

    public Dummy(int health, int experience)
    {
        this.health = health;
        this.experience = experience;
    }

    public int Health 
    {
        get { return this.health; }
    }

    public void TakeAttack(int attackPoints)
    {
        if (this.IsDead)
        {
            throw new InvalidOperationException("Dummy is dead.");
        }

        this.health -= attackPoints;
    }

    public int GiveExperience
    {
        get
        {
            if (!this.IsDead)
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.experience;
        }
    }

    public bool IsDead => this.health <= 0;
}
