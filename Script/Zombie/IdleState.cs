public class IdleState : State
{
    public IdleState(Enemy enemy) : base(enemy)
    {
        _enemy.DoIdle();
    }

    public override void UpdateState()
    {
        _enemy.SetState(new WalkState(_enemy));
    }
}
